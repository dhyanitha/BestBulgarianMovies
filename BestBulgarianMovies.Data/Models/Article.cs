﻿namespace BestBulgarianMovies.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Article
    {
        public int Id { get; set; }

        [Required]
        [MinLength(DataConstants.ArticleTitleMinLength)]
        [MaxLength(DataConstants.ArticleTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(DataConstants.ArticleContentMinLenght)]
        public string Content { get; set; }

        [Required]
        [MaxLength(DataConstants.ArticleThumbnailMaxLenght)]
        public string ThumbnailUrl { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }
    }
}