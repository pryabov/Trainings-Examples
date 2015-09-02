window.beforeActionLink = {
	isFirstPartial: true,
	changePartial: function () {
		var self = this;

		$.ajax({
			data: {
				isFirstPartial: self.isFirstPartial
			},
			url: beforeActionLink.partialRequestUrl,
			success: function (data) {
				$('#update-container').html(data);
				self.isFirstPartial = !self.isFirstPartial;
			}
		});
	}
};
