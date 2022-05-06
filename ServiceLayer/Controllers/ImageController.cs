using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer.Controllers
    {
    public class ImageController : IRepository<Image, int>
        {
        private ImageRepository _imageRepository;

        public ImageController(GloNetDbContext context)
            {
            _imageRepository = new ImageRepository(context);
            }

        public void Create(Image item)
            {
            try
                {
                _imageRepository.Create(item);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public Image Read(int key)
            {
            try
                {
                return _imageRepository.Read(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Image> Read(int skip, int take)
            {
            try
                {
                return _imageRepository.Read(skip, take);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<Image> ReadAll()
            {
            try
                {
                return _imageRepository.ReadAll();
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
                _imageRepository.Update(item);
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
                _imageRepository.Delete(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }
        }
    }
