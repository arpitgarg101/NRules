// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Transaction.cs" company="Microsoft">
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
//   OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//   ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//   OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NRules.Samples.RuleBuilder.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The transaction.
    /// </summary>
    public class Transaction
    {
        public Transaction()
        {
        }

        /// <summary>
        /// Gets or sets the transaction unique identity.
        /// </summary>
        /// <value>The transaction unique identity.</value>
        [MaxLength(50)]
        public string TransactionGuid { get; set; }

        /// <summary>
        /// Gets or sets the user identity.
        /// </summary>
        /// <value>The user identity.</value>
        
        [MaxLength(100)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user identity type.
        /// </summary>
        /// <value>The user identity type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public UserIdType UserIdType { get; set; }

        /// <summary>
        /// Gets or sets the user profile identifier.
        /// </summary>
        /// <value>
        /// The user profile identifier.
        /// </value>
        public int UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the organization identity.
        /// </summary>
        /// <value>The id of the organization (e.g. Astra BU, partners etc.) of which the transaction happens with.</value>
        
        public int OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        [MaxLength(10)]
        public string Currency { get; set; } = "IDR";

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>The products the user purchased in the transaction.</value>
        public List<Purchase> Purchases { get; set; }

        /// <summary>
        /// Gets or sets the extensions.
        /// </summary>
        /// <value>Additional properties which are reserved for future purpose.</value>
        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// Gets or sets the transaction time.
        /// </summary>
        /// <value>The time when the transaction happened.</value>
        public DateTime TransactionTime { get; set; }

        /// <summary>
        /// Gets or sets the expiry date.
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets the transaction value.
        /// </summary>
        /// <value>The transaction value.</value>
        [Range(0, double.MaxValue)]
        public double TransactionValue { get; set; }

        /// <summary>
        /// Gets or sets the points value.
        /// </summary>
        /// <value>The points value.</value>
        [Range(0, double.MaxValue)]
        public double PointsValue { get; set; }

        /// <summary>
        /// Gets or sets the transaction type.
        /// </summary>
        /// <value>The transaction type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transaction is online.
        /// </summary>
        /// <value>A flag for online transaction.</value>
        public bool OnlineTransaction { get; set; } = false;

        /// <summary>
        /// Gets or sets the email address of the submitter.
        /// </summary>
        /// <value>The email address or identity of the user who submit the request to loyalty engine.</value>
        [MaxLength(250)]
        public string SubmittedBy { get; set; }

        /// <summary>
        /// Gets or sets the time when the request is submitted.
        /// </summary>
        /// <value>The time when the request is submitted.</value>
        public DateTime SubmittedAt { get; set; }

        /// <summary>
        /// Gets or sets the transaction status.
        /// </summary>
        /// <value>The transaction status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionStatusCode TransactionStatus { get; set; }

        /// <summary>
        /// Gets or sets the transaction notes.
        /// </summary>
        /// <value>The transaction notes.</value>
        public string TransactionNotes { get; set; }

        public void CalculatePoint(double multipler)
        {
            this.PointsValue = this.TransactionValue * multipler;
        }
    }
}