using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
    {
    public class ReactionTypeRepository : IDB<ReactionType, int>
        {
        private GloNetDbContext _context;

        public ReactionTypeRepository(GloNetDbContext context)
            {
            this._context = context;
            }
        public void Create(ReactionType item)
            {
            try
                {
                _context.ReactionTypes.Add(item);
                _context.SaveChanges();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public ReactionType Read(int key, bool noTracking = false, bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<ReactionType> reactionTypes = _context.ReactionTypes;

                if(noTracking)
                    {
                    reactionTypes = reactionTypes.AsNoTrackingWithIdentityResolution();
                    }

                if(useNavigationProperties)
                    {
                    reactionTypes = reactionTypes.Include(r => r.ReactionPhoto);
                    }

                ReactionType reactionTypeFromDB = reactionTypes.SingleOrDefault(r => r.ID == key);

                if(reactionTypeFromDB == null)
                    {
                    throw new ArgumentException("There is no ReactionType with this id! ");
                    }

                return reactionTypeFromDB;
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<ReactionType> Read(int skip, int take, bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<ReactionType> reactionTypes = _context.ReactionTypes.AsNoTrackingWithIdentityResolution();

                if(useNavigationProperties)
                    {
                    reactionTypes = reactionTypes.Include(r => r.ReactionPhoto);
                    }

                return reactionTypes.Skip(skip).Take(take).ToList();
                }

            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<ReactionType> ReadAll(bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<ReactionType> reactionTypes = _context.ReactionTypes.AsNoTrackingWithIdentityResolution();

                if(useNavigationProperties)
                    {
                    reactionTypes = reactionTypes.Include(r => r.ReactionPhoto);
                    }

                return reactionTypes.ToList();
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
                ReactionType reactionTypeFromDB = Read(item.ID);
                _context.Entry(reactionTypeFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
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
                _context.ReactionTypes.Remove(Read(key));
                _context.SaveChanges();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }
        }
    }
