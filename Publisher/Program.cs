// See https://aka.ms/new-console-template for more information
using PublisherData;

using (PublisherContext context = new PublisherContext())
{
    context.Database.EnsureCreated();

}


