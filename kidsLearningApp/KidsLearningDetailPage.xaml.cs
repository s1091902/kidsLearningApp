namespace kidsLearningApp;

public partial class KidsLearningDetailPage : ContentPage
{
	public KidsLearningDetailPage(string categoryName)
	{
		InitializeComponent();
		DisplayLearningResult(categoryName);
		Title = categoryName;

    }

	private void DisplayLearningResult(string categoryName)
	{
		LearningData learningData = new LearningData();
		switch (categoryName)
		{
            case "Numbers":
                CvKids.ItemsSource =learningData.Numbers; break;
            case "Letters":
                CvKids.ItemsSource =learningData.Letters; break;
            case "Shapes":
                CvKids.ItemsSource =learningData.Shapes; break;
            case "Colors":
                CvKids.ItemsSource= learningData.Colors; break;
            default:
                break;
        }

	}

    


}