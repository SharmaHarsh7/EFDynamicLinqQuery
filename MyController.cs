  [Route("")]
        public HttpResponseMessage Get(string columns)
        {
            IList<string> selectedProperties = columns.Split(',').ToList();


            using (DBContext dbContext = new DBContext())
            {
                var data = dbContext.Employee.Where(x => x.FirstName.StartsWith("G")).SelectProperties(selectedProperties);


                return Request.CreateResponse(HttpStatusCode.OK, data.ToList());
            }

}
