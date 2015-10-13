		/// <summary>
		/// Replaces default identity with custom <see cref="MyIdentity"/> which is identical by claims to current one. 
		/// </summary>
		public static IAppBuilder SetMyIdentity(this IAppBuilder builder, IContainer container)
		{
			// need to think about possibility of removing current filter
			builder.Use((context, next) =>
			{
				if (context.Request.User != null &&
					!(context.Request.User.Identity is MyIdentity) && 
					context.Request.User.Identity.IsAuthenticated)
				{
					IMyIdentity identity = MyIdentity.CreateFromClaimsIdentity((ClaimsIdentity)context.Request.User.Identity);

					MyPrincipal principal = new MyPrincipal(identity);
					context.Request.User = principal;
				}
				return next.Invoke();
			});
			builder.UseStageMarker(PipelineStage.PostAuthenticate);
			return builder;
		}