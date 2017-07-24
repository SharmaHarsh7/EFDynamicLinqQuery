  [Route("")]
        public HttpResponseMessage Get(string columns)
        {
            IList<string> selectedProperties = columns.Split(',').ToList();


            using (NutriSolutionsEntities dbContext = new NutriSolutionsEntities())
            {
                var data = dbContext.Growers.Where(x => x.FirstName.StartsWith("G")).SelectProperties(selectedProperties);


                return Request.CreateResponse(HttpStatusCode.OK, data.ToList());
            }

}
