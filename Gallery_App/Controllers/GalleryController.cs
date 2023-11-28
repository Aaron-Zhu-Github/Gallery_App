using System;
using System.Collections.Generic;
using Gallery_App.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace Gallery_App.Controllers;
public class GalleryController : Controller
{
    public IActionResult Index()
    {
        // Retrieve a list of images
        var images = GetImages();
        return View(images);
    }


    private List<Image> GetImages()
    {
        return new List<Image>
    {
        new Image { Id = 1, Url = "images/image1.jpg" },
        new Image { Id = 2, Url = "images/image2.jpg" },
        new Image { Id = 3, Url = "images/image3.jpg" },
        new Image { Id = 4, Url = "images/image4.jpg" },
        new Image { Id = 5, Url = "images/image5.jpg" },
        new Image { Id = 6, Url = "images/image6.jpg" },
        new Image { Id = 7, Url = "images/image7.jpg" },
        new Image { Id = 8, Url = "images/image8.jpg" },
        new Image { Id = 9, Url = "images/image9.jpg" },
        new Image { Id = 10, Url = "images/image10.jpg" },
        new Image { Id = 11, Url = "images/image11.jpg" },
        new Image { Id = 12, Url = "images/image12.jpg" },
        new Image { Id = 13, Url = "images/image13.jpg" },
        new Image { Id = 14, Url = "images/image14.jpg" },
        new Image { Id = 15, Url = "images/image15.jpg" }
    };
    }

    // Show images from equal-size view to detail view by images_id
    public IActionResult DetailView(int id)
    {
        // Get the image by id
        var image = GetImages().FirstOrDefault(i => i.Id == id);
        // If the image is not found, redirect to the Index action of the gallery
        if (image == null)
        {
            return RedirectToAction("Index");
        }

        return View(image);
    }
}