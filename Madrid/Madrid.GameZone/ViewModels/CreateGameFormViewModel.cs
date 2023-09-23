using Madrid.GameZone.Attributes;
using Madrid.GameZone.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Madrid.GameZone.ViewModels
{
    public class CreateGameFormViewModel: GameFormViewModel
    {
        [AllowedExtensions(FileSettings.AllowedExtensions),
            MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;

    }
}
