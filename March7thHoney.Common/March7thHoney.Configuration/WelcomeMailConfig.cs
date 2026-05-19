using System.Collections.Generic;

namespace March7thHoney.Configuration;

public class WelcomeMailConfig
{
	public bool Enabled { get; set; } = true;

	public string Sender { get; set; } = "March7thHoney";

	public string Title { get; set; } = "Welcome";

	public string Content { get; set; } = "Welcome, {username}!";

	public int TemplateId { get; set; }

	public int ExpireDays { get; set; } = 30;

	public bool IsStar { get; set; }

	public List<WelcomeMailItemConfig> Items { get; set; } = new List<WelcomeMailItemConfig>();
}
