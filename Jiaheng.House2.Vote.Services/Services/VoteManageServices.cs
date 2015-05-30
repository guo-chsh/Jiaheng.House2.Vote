using Jiaheng.House2.Vote.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.DTO.ViewModel;
using Jiaheng.House2.Vote.Repository.Interfaces;
using Jiaheng.House2.Vote.Entities;


namespace Jiaheng.House2.Vote.Services.Services
{
    /// <summary>
    /// 投票活动主要操作实现类
    /// </summary>
    public class VoteManageServices : IVoteManageServices
    {
        IVoteItemRepository<Vote_items> _iVoteItemRepository;
        IVoteMainRepository<Vote_main> _iVoteMainRepository;
        IChooseDetailsRepository<Vote_ChooseDetails> _iChooseDetailsRepository;
        IArticlesRepository<Selectobj_articles> _iArticlesRepository;
        IPictureRepository<Selectobj_pics> _iPictureRepository;

        #region 构造

        public VoteManageServices(IVoteItemRepository<Vote_items> iVoteItemRepository,
        IVoteMainRepository<Vote_main> iVoteMainRepository,
        IChooseDetailsRepository<Vote_ChooseDetails> iChooseDetailsRepository,
        IArticlesRepository<Selectobj_articles> iArticlesRepository,
        IPictureRepository<Selectobj_pics> iPictureRepository
        )
        {
            _iVoteItemRepository = iVoteItemRepository;
            _iVoteMainRepository = iVoteMainRepository;
            _iChooseDetailsRepository = iChooseDetailsRepository;
            _iArticlesRepository = iArticlesRepository;
            _iPictureRepository = iPictureRepository;
        }
        #endregion

        /// <summary>
        /// 实体转换类，此方法可以用dtomapping框架替换，本例暂不使用
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public object ConvertToViewModel(object entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 创建一个投票活动
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CreateVoteMain(VoteMainViewModel model)
        {
            var vote = new Vote_main
            {
                Begintime = model.Begintime,
                Endtime = model.Endtime,
                Createtime = DateTime.Now,
                VoteDescription = model.Description,
                VoteName = model.VoteTile,
                VoteType = model.Votemaintype
            };
            _iVoteMainRepository.Create(vote);

            var items = new List<Vote_items>();
            foreach (var m in model.VoteItems)
                items.Add(m.ToDataModel());
            _iVoteItemRepository.AddRange(items);

            //执行修改
            return Entityframework.Entities.Current.SaveChanges() > 0;
        }

        /// <summary>
        /// 客户投票操作方法，暂不考虑高并发操作，试用EF自带事务操作。
        /// </summary>
        /// <param name="userinfo"></param>
        /// <param name="voteitemid"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool DoVote(LoginViewModel userinfo, int voteitemid, string ip)
        {
            var choose = new Vote_ChooseDetails
            {
                Createtime = DateTime.Now,
                UserChooseIp = ip,
                Userid = userinfo.ID,
                VoteItemId = voteitemid
            };

            _iChooseDetailsRepository.Create(choose);
            var voteitem = _iVoteItemRepository.Single(m => m.id == voteitemid);
            voteitem.VoteCounts++;

            Entityframework.Entities.Current.SaveChanges();

            return false;
        }

        /// <summary>
        /// 获取所有的投票活动
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VoteMainViewModel> GetAllVotes()
        {
            var list = _iVoteMainRepository.GetAll();
            var nlist = new List<VoteMainViewModel>();
            foreach (var item in list)
            {
                var model = new VoteMainViewModel
                {
                    Begintime = item.Begintime,
                    Description = item.VoteDescription,
                    Endtime = item.Endtime,
                    ID = item.ID,
                    VoteTile = item.VoteName,
                    VoteItems = new List<VoteItemViewModel>()
                };

                foreach (var m in _iVoteItemRepository.Find(m => m.VotemainId == item.ID))
                {
                    var vitem = new VoteItemViewModel
                    {
                        ID = m.id,
                        VoteCounts = m.VoteCounts,
                        VoteInitialCounts = m.VoteInitialCounts,
                        VotemainID = m.VotemainId,
                        VoteItemName = m.VoteItemName,
                        SelectObjID = m.SelectobjID,
                        TypeChar = m.VoteType
                    };
                }
                nlist.Add(model);
            }
            return nlist;
        }

        /// <summary>
        /// 根据ID获取某一个投票活动
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VoteMainViewModel GetVoteByid(int id)
        {
            var data = _iVoteMainRepository.Single(m => m.ID == id);
            var model = new VoteMainViewModel
            {
                Begintime = data.Begintime,
                Description = data.VoteDescription,
                Endtime = data.Endtime,
                ID = data.ID,
                Votemaintype = data.VoteType,
                VoteTile = data.VoteName
            };
            model.VoteItems = new List<VoteItemViewModel>();
            foreach (var item in _iVoteItemRepository.Find(m => m.VotemainId == data.ID))
            {
                var itemmodel = new VoteItemViewModel
                {
                    ID = item.id,
                    SelectObjID = item.SelectobjID,
                    TypeChar = item.VoteType,
                    VoteCounts = item.VoteCounts,
                    VoteInitialCounts = item.VoteInitialCounts,
                    VoteItemName = item.VoteItemName,
                    VotemainID = item.VotemainId
                };
                model.VoteItems.Add(itemmodel);
            }

            return model;
        }

        /// <summary>
        /// 修改投票选项票数的时候进行操作
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateVoteItemChooseCounts(VoteItemViewModel model)
        {
            var data = _iVoteItemRepository.Single(m => m.id == model.ID);
            //修改要改的东西
            data.VoteCounts = model.VoteCounts;
            return Entityframework.Entities.Current.SaveChanges() > 0;
        }
    }
}
