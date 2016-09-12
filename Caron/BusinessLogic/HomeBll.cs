using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Caron.DAL.Models;
using Caron.DAL.ViewModels.Home;

namespace Caron.BusinessLogic
{
    public class HomeBll : BaseBll
    {
        public HomeBll(CaronEntities db) : base(db)
        {
        }

        public HomeIndexViewModel RenderIndex()
        {


            var sections = Db.DescriptionSections.Select(x => new DescriptionSectionViewModel
            {
                DescriptionSectionId = x.DescriptionId,
                Description = x.DescriptionBody,
                Title = x.DescriptionTitle
            }).ToList();

            var viewModel = new HomeIndexViewModel
            {
                DescriptionSections = sections,
            };
            return viewModel;
        }

         public void CreateDescriptionSection(DescriptionSectionViewModel viewModel)
        {
            Db.DescriptionSections.Add(new DescriptionSection
            {
                DescriptionTitle = viewModel.Title,
                DescriptionBody = viewModel.Description,
                CreatedDate = DateTime.Now
            });

            Db.SaveChanges();
        }
        
        public void UpdateDescriptionSection(DescriptionSectionViewModel viewModel)
        {
            var theSection = Db.DescriptionSections.Find(viewModel.DescriptionSectionId);
            if (theSection == null) return;

            theSection.DescriptionBody = viewModel.Description;
            theSection.DescriptionTitle = viewModel.Title;

            Db.SaveChanges();
        }

        public DescriptionSectionViewModel UpdateDescriptionSection(int descriptionSectionId)
        {
            var theSection = Db.DescriptionSections.Find(descriptionSectionId);
            var viewModel = new DescriptionSectionViewModel
            {
                DescriptionSectionId = descriptionSectionId,
                Description = theSection.DescriptionBody,
                Title = theSection.DescriptionTitle
            };

            return viewModel;
        }

        public void DeleteDescriptionSection(int descriptionSectionId)
        {
            var theSection = Db.DescriptionSections.Find(descriptionSectionId);
            if (theSection == null) return;
            Db.DescriptionSections.Remove(theSection);
            Db.SaveChanges();
        }
    }
}