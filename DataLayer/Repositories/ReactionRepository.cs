using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
    {
    public class ReactionRepository : IDB<Reaction, int>
        {
        private GloNetDbContext _context;

        public ReactionRepository(GloNetDbContext context)
            {
            this._context = context;
            }

        public void Create(Reaction item)
            {
            try
                {
                _context.Reactions.Add(item);
                _context.SaveChanges();
                }
            catch (Exception ex)
                {
                throw ex; 
                }
            }

        
        public Reaction Read(int key, bool noTracking = false, bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<Reaction> reactions = _context.Reactions;

                    if (noTracking)
                    {
                    reactions = reactions.AsNoTrackingWithIdentityResolution();
                    }

                if(useNavigationProperties)
                    {
                    reactions = reactions.Include(r => r.TypeID).Include(r => r.User).Include(r => r.Post);
                    }

                Reaction reactionFromDB = reactions.SingleOrDefault(r => r.ID == key);
                
                if(reactionFromDB == null)
                    {
                    throw new ArgumentException("There is no reaction with that id!");
                    }

                return reactionFromDB;
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Reaction> Read(int skip, int take, bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<Reaction> reactions = _context.Reactions.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                    {
                    reactions = reactions.Include(r => r.TypeID).Include(r => r.User).Include(r => r.Post);
                    }

                return reactions.Skip(skip).Take(take).ToList();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Reaction> ReadAll(bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<Reaction> reactions = _context.Reactions.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                    {
                    reactions = reactions.Include(r => r.TypeID).Include(r => r.User).Include(r => r.Post);
                    }

                return reactions.ToList();
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
                Reaction reactionFromDB = Read(item.ID);
                _context.Entry(reactionFromDB).CurrentValues.SetValues(item);
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
                _context.Reactions.Remove(Read(key));
                _context.SaveChanges();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }
        }
    }
