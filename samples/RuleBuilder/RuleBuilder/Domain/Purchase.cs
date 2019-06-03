// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Purchase.cs" company="Microsoft">
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//    THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
//    OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NRules.Samples.RuleBuilder.Domain
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The Purchase.
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// Gets or sets the product identity.
        /// </summary>
        /// <value>
        /// The id of the product.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public PurchaseType Type { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The currency value of the product in this transaction.
        /// </value>
        [Range(0, double.MaxValue)]
        public double CurrencyValue { get; set; }

        /// <summary>
        /// Gets or sets the points value.
        /// </summary>
        /// <value>
        /// The points value.
        /// </value>
        [Range(0, double.MaxValue)]
        public double PointsValue { get; set; }
    }
}