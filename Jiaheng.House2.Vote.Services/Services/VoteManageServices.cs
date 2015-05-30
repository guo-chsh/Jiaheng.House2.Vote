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
        IVoteMainTypesRepository<Vote_maintypes> _iVoteMainTypesRepository;

        #region 构造

        public VoteManageServices(IVoteItemRepository<Vote_items> iVoteItemRepository,
        IVoteMainRepository<Vote_main> iVoteMainRepository,
        IChooseDetailsRepository<Vote_ChooseDetails> iChooseDetailsRepository,
        IArticlesRepository<Selectobj_articles> iArticlesRepository,
        IPictureRepository<Selectobj_pics> iPictureRepository,
        IVoteMainTypesRepository<Vote_maintypes> iVoteMainTypesRepository
        )
        {
            _iVoteItemRepository = iVoteItemRepository;
            _iVoteMainRepository = iVoteMainRepository;
            _iChooseDetailsRepository = iChooseDetailsRepository;
            _iArticlesRepository = iArticlesRepository;
            _iPictureRepository = iPictureRepository;
            _iVoteMainTypesRepository = iVoteMainTypesRepository;
        }
        #endregion
        public object ConvertToViewModel(object entity)
        {
            throw new NotImplementedException();
        }

        public Vote_items ConvertoDataModel(VoteItemViewModel item)
        {
            return new Vote_items
            {
                CreateTime = DateTime.Now,
                SelectobjID = item.Selectobj.ID,
                VoteCounts = item.VoteCounts,
                VoteInitialCounts = item.VoteInitialCounts,
                VoteItemName = item.VoteItemName,
                VotemainId = item.VotemainID,
                VoteTypeID = item.MainType.ID

            };
        }

        public bool CreateVoteMain(VoteMainViewModel model)
        {
            var vote = new Vote_main
            {
                Begintime = model.Begintime,
                Endtime = model.Endtime,
                Createtime = DateTime.Now,
                VoteDescription = model.Description,
                VoteName = model.VoteTile,
                VoteTypeID = model.Votemaintype.ID
            };

            _iVoteMainRepository.Create(vote);
            var items = new List<Vote_items>();
            foreach (var m in model.VoteItems)
                items.Add(ConvertoDataModel(m));
            _iVoteItemRepository.AddRange(items);
            Entityframework.Entities.Current.SaveChanges();

            return false;
        }

        public bool DoVote(LoginViewModel userinfo, int voteitemid, string ip)
        {

            return false;
        }

        public IEnumerable<VoteMainViewModel> GetAllVotes()
        {
            var list = _iVoteMainRepository.GetAll();
            var nlist = new List<VoteMainViewModel>();
            foreach (var item in list)
            {
                nlist.Add(new VoteMainViewModel
                {
                    Begintime = item.Begintime.Value,
                    Description = item.VoteDescription,
                    Endtime = item.Endtime.Value,
                    ID = item.ID,
                    VoteTile = item.VoteName,
                     VoteItems = _iVoteItemRepository.GetAll()
                });
            }
            return nlist;
        }

        public VoteMainViewModel GetVoteByid(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateVoteItemChooseCounts(VoteItemViewModel model)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<VoteMaintypeViewModel> GetAllTypes()
        {
            return null;
        }
    }
}
