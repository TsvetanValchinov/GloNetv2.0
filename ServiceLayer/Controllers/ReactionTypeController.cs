using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer.Controllers
    {
    public class ReactionTypeController : IRepository<ReactionType, int>
        {
        private ReactionTypeRepository _reactionTypeRepository;

        public ReactionTypeController(GloNetDbContext context)
            {
            _reactionTypeRepository = new ReactionTypeRepository(context);
            }

        public void Create(ReactionType item)
            {
            try
                {
                _reactionTypeRepository.Create(item);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public ReactionType Read(int key)
            {
            try
                {
                return _reactionTypeRepository.Read(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<ReactionType> Read(int skip, int take)
            {
            try
                {
                return _reactionTypeRepository.Read(skip, take);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<ReactionType> ReadAll()
            {
            try
                {
                return _reactionTypeRepository.ReadAll();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public void Update(ReactionType item)
            {
            try
                {
                _reactionTypeRepository.Update(item);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public void Delete(int key)
            {
            try
                {
                _reactionTypeRepository.Delete(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }
        }
    }
