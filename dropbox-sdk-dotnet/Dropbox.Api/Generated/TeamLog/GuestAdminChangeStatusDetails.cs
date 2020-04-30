// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed guest team admin status.</para>
    /// </summary>
    public class GuestAdminChangeStatusDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GuestAdminChangeStatusDetails> Encoder = new GuestAdminChangeStatusDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GuestAdminChangeStatusDetails> Decoder = new GuestAdminChangeStatusDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GuestAdminChangeStatusDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="isGuest">True for guest, false for host.</param>
        /// <param name="previousValue">Previous request state.</param>
        /// <param name="newValue">New request state.</param>
        /// <param name="actionDetails">Action details.</param>
        /// <param name="guestTeamName">The name of the guest team.</param>
        /// <param name="hostTeamName">The name of the host team.</param>
        public GuestAdminChangeStatusDetails(bool isGuest,
                                             TrustedTeamsRequestState previousValue,
                                             TrustedTeamsRequestState newValue,
                                             TrustedTeamsRequestAction actionDetails,
                                             string guestTeamName = null,
                                             string hostTeamName = null)
        {
            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (actionDetails == null)
            {
                throw new sys.ArgumentNullException("actionDetails");
            }

            this.IsGuest = isGuest;
            this.PreviousValue = previousValue;
            this.NewValue = newValue;
            this.ActionDetails = actionDetails;
            this.GuestTeamName = guestTeamName;
            this.HostTeamName = hostTeamName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GuestAdminChangeStatusDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GuestAdminChangeStatusDetails()
        {
        }

        /// <summary>
        /// <para>True for guest, false for host.</para>
        /// </summary>
        public bool IsGuest { get; protected set; }

        /// <summary>
        /// <para>Previous request state.</para>
        /// </summary>
        public TrustedTeamsRequestState PreviousValue { get; protected set; }

        /// <summary>
        /// <para>New request state.</para>
        /// </summary>
        public TrustedTeamsRequestState NewValue { get; protected set; }

        /// <summary>
        /// <para>Action details.</para>
        /// </summary>
        public TrustedTeamsRequestAction ActionDetails { get; protected set; }

        /// <summary>
        /// <para>The name of the guest team.</para>
        /// </summary>
        public string GuestTeamName { get; protected set; }

        /// <summary>
        /// <para>The name of the host team.</para>
        /// </summary>
        public string HostTeamName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GuestAdminChangeStatusDetails" />.</para>
        /// </summary>
        private class GuestAdminChangeStatusDetailsEncoder : enc.StructEncoder<GuestAdminChangeStatusDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GuestAdminChangeStatusDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("is_guest", value.IsGuest, writer, enc.BooleanEncoder.Instance);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.TrustedTeamsRequestState.Encoder);
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.TrustedTeamsRequestState.Encoder);
                WriteProperty("action_details", value.ActionDetails, writer, global::Dropbox.Api.TeamLog.TrustedTeamsRequestAction.Encoder);
                if (value.GuestTeamName != null)
                {
                    WriteProperty("guest_team_name", value.GuestTeamName, writer, enc.StringEncoder.Instance);
                }
                if (value.HostTeamName != null)
                {
                    WriteProperty("host_team_name", value.HostTeamName, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GuestAdminChangeStatusDetails" />.</para>
        /// </summary>
        private class GuestAdminChangeStatusDetailsDecoder : enc.StructDecoder<GuestAdminChangeStatusDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GuestAdminChangeStatusDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GuestAdminChangeStatusDetails Create()
            {
                return new GuestAdminChangeStatusDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GuestAdminChangeStatusDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "is_guest":
                        value.IsGuest = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.TrustedTeamsRequestState.Decoder.Decode(reader);
                        break;
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.TrustedTeamsRequestState.Decoder.Decode(reader);
                        break;
                    case "action_details":
                        value.ActionDetails = global::Dropbox.Api.TeamLog.TrustedTeamsRequestAction.Decoder.Decode(reader);
                        break;
                    case "guest_team_name":
                        value.GuestTeamName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "host_team_name":
                        value.HostTeamName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}