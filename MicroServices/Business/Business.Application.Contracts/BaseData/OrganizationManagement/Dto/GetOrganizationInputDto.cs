﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.BaseData.OrganizationManagement.Dto
{
    public class GetOrganizationInputDto : PagedAndSortedResultRequestDto
    {
        public Guid? Id { get; set; }

        public string Filter { get; set; }

        public short? CategoryId { get; set; }

        public Guid? Pid { get; set; }
    }
}
