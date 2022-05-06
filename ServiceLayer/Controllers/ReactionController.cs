using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer.Controllers
    {
    public class ReactionController : IRepository<Reaction, int>
        {
        private ReactionRepository _reactionRepository;

        public ReactionController(GloNetDbContext context)
            {
            _reactionRepository = new ReactionRepository(context);
            }

        public void Create(Reaction item)
            {
            try
                {
                _reactionRepository.Create(item);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public Reaction Read(int key)
            {
            try
                {
                return _reactionRepository.Read(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Reaction> Read(int skip, int take)
            {
            try
                {
                return _reactionRepository.Read(skip, take);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Reaction> ReadAll()
            {
            try
                {
                return _reactionRepository.ReadAll();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public void Update(Reaction item)
            {
            try
                {
                _reactionRepository.Update(item);
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
                _reactionRepository.Delete(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }
        }
    }
