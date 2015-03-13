﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMon.Zabbix.Entities
{
    public partial class IconMap
    {
        #region Properties

        /// <summary>
        /// (readonly) ID of the icon map.
        /// </summary>
        public string iconmapid { get; set; }

        /// <summary>
        /// ID of the default icon.
        /// </summary>
        public string default_iconid { get; set; }

        /// <summary>
        /// Name of the icon map.
        /// </summary>
        public string name { get; set; }

        #endregion

        #region Associations

        public IList<IconMapping> mappings { get; set; }

        #endregion
    }

    public partial class IconMapping
    {
        #region Properties

        /// <summary>
        /// (readonly) ID of the icon map.
        /// </summary>
        public string iconmappingid { get; set; }

        /// <summary>
        /// ID of the icon used by the icon mapping.
        /// </summary>
        public string iconid { get; set; }

        /// <summary>
        /// Expression to match the inventory field against.
        /// </summary>
        public string expression { get; set; }

        /// <summary>
        /// ID of the host inventory field. 
        /// 
        /// Refer to the host inventory object for a list of supported inventory fields.
        /// </summary>
        public int inventory_link { get; set; }

        /// <summary>
        /// (readonly) ID of the icon map that the icon mapping belongs to.
        /// </summary>
        public string iconmapid { get; set; }

        /// <summary>
        /// Position of the icon mapping in the icon map. 
        /// 
        /// Default: 0.
        /// </summary>
        public int sortorder { get; set; }

        #endregion
    }

}
