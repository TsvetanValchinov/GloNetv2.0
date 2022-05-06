using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
    {
    public class ImageRepository : IDB<Image,int>
        {
        private GloNetDbContext _context;

        public ImageRepository(GloNetDbContext context)
            {
            this._context = context;
            }

        public void Create(Image item)
            {
            try
                {
                _context.Images.Add(item);
                _context.SaveChanges();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public Image Read(int key, bool noTracking = false, bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<Image> images = _context.Images;

                if(noTracking)
                    {
                    images = images.AsNoTrackingWithIdentityResolution();
                    }

                Image imageFromDb = images.SingleOrDefault(i => i.Id == key);
               
                if(imageFromDb == null)
                    {
                    throw new ArgumentException("There is no image with that id!");
                    }

                return imageFromDb;
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Image> Read(int skip, int take, bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<Image> images = _context.Images.AsNoTrackingWithIdentityResolution();
                return images.Skip(skip).Take(take).ToList();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Image> ReadAll(bool useNavigationProperties = false)
            {
            try
                {
                IQueryable<Image> images = _context.Images.AsNoTrackingWithIdentityResolution();
                return images.ToList();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public void Update(Image item)
            {
            try
                {
                Image imageFromDB = Read(item.Id);
                _context.Entry(imageFromDB).CurrentValues.SetValues(item);
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
                _context.Images.Remove(Read(key));
                _context.SaveChanges();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        }
    }
