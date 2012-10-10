using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Bootstrap.Laces
{
    /// <summary>
    /// Bootstrap ValidationExtensions AlertBox Themed Validator
    /// </summary>
    public static class ValidationExtensions
    {
        /// <summary>
        /// Bootstrap  AlertBox Themed Validation Extension.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="alertStatus">The alert status.</param>
        /// <returns>The Validation Message wrapped in a Twitter Bootstrap Alert Box</returns>
        public static MvcHtmlString BootstrapValidationMessageFor<TModel, TProperty>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty>> expression, Bootstrap.Laces.AlertBoxStatuses alertStatus = AlertBoxStatuses.Error, bool includeCloseButton = false)
        {

            string closeButton = (includeCloseButton ? "<button type='button' class='close' data-dismiss='alert'>×</button>" : "");
            string elementName = ExpressionHelper.GetExpressionText(expression);
            MvcHtmlString normal = html.ValidationMessageFor(expression);
            if (normal != null)
            {
                string newValidator = Regex.Replace(normal.ToHtmlString(), @"<span([^>]*)>([^<]*)</span>", string.Format("<div for='{0}' class='alert alert-{1} field-validation-valid' $1>{2}$2</div>", elementName, alertStatus.ToString().ToLower(), closeButton.ToString()), RegexOptions.IgnoreCase);
                return MvcHtmlString.Create(newValidator);
            }
            return null;
        }
    }
}