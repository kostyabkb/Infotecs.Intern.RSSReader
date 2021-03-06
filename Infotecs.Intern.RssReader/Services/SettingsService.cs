﻿using Infotecs.Intern.RssReader.Models;
using Microsoft.Extensions.Options;

namespace Infotecs.Intern.RssReader.Services
{
    /// <inheritdoc/>>
    public class SettingsService
    {
        private RssReaderOptions options;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="options">Параметры.</param>
        public SettingsService(IOptions<RssReaderOptions> options)
        {
            this.options = options.Value;
        }

        public RssReaderOptions GetSettings()
        {
            return options;
        }

        public void SaveSettings(RssReaderOptions options)
        {
            this.options = options;
        }

        public int CompareTo(object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}