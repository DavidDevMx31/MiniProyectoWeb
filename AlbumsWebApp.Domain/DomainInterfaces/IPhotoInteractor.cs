﻿using AlbumsWebApp.Domain.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsWebApp.Domain.DomainInterfaces
{
    public interface IPhotoInteractor
    {
        void GetAllPhotos(IPhotoPresenter presenter);
        void GetPhotosForAlbum(int albumId, IPhotoPresenter presenter);
    }
}
