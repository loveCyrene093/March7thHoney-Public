using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CHDLBDDHKDJ : IMessage<CHDLBDDHKDJ>, IMessage, IEquatable<CHDLBDDHKDJ>, IDeepCloneable<CHDLBDDHKDJ>, IBufferMessage
{
	private static readonly MessageParser<CHDLBDDHKDJ> _parser = new MessageParser<CHDLBDDHKDJ>(() => new CHDLBDDHKDJ());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int HLHCKPPNPNHFieldNumber = 2;

	private HABFLMJEEKL hLHCKPPNPNH_;

	public const int BNDGGNDMEMCFieldNumber = 3;

	private HABFLMJEEKL bNDGGNDMEMC_;

	public const int StopDescFieldNumber = 4;

	private string stopDesc_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CHDLBDDHKDJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CHDLBDDHKDJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HABFLMJEEKL HLHCKPPNPNH
	{
		get
		{
			return hLHCKPPNPNH_;
		}
		set
		{
			hLHCKPPNPNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HABFLMJEEKL BNDGGNDMEMC
	{
		get
		{
			return bNDGGNDMEMC_;
		}
		set
		{
			bNDGGNDMEMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string StopDesc
	{
		get
		{
			return stopDesc_;
		}
		set
		{
			stopDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDLBDDHKDJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDLBDDHKDJ(CHDLBDDHKDJ other)
		: this()
	{
		avatarId_ = other.avatarId_;
		hLHCKPPNPNH_ = ((other.hLHCKPPNPNH_ != null) ? other.hLHCKPPNPNH_.Clone() : null);
		bNDGGNDMEMC_ = ((other.bNDGGNDMEMC_ != null) ? other.bNDGGNDMEMC_.Clone() : null);
		stopDesc_ = other.stopDesc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDLBDDHKDJ Clone()
	{
		return new CHDLBDDHKDJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CHDLBDDHKDJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CHDLBDDHKDJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!object.Equals(HLHCKPPNPNH, other.HLHCKPPNPNH))
		{
			return false;
		}
		if (!object.Equals(BNDGGNDMEMC, other.BNDGGNDMEMC))
		{
			return false;
		}
		if (StopDesc != other.StopDesc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (hLHCKPPNPNH_ != null)
		{
			num ^= HLHCKPPNPNH.GetHashCode();
		}
		if (bNDGGNDMEMC_ != null)
		{
			num ^= BNDGGNDMEMC.GetHashCode();
		}
		if (StopDesc.Length != 0)
		{
			num ^= StopDesc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		if (hLHCKPPNPNH_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HLHCKPPNPNH);
		}
		if (bNDGGNDMEMC_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BNDGGNDMEMC);
		}
		if (StopDesc.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(StopDesc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (hLHCKPPNPNH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HLHCKPPNPNH);
		}
		if (bNDGGNDMEMC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNDGGNDMEMC);
		}
		if (StopDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StopDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CHDLBDDHKDJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
		}
		if (other.hLHCKPPNPNH_ != null)
		{
			if (hLHCKPPNPNH_ == null)
			{
				HLHCKPPNPNH = new HABFLMJEEKL();
			}
			HLHCKPPNPNH.MergeFrom(other.HLHCKPPNPNH);
		}
		if (other.bNDGGNDMEMC_ != null)
		{
			if (bNDGGNDMEMC_ == null)
			{
				BNDGGNDMEMC = new HABFLMJEEKL();
			}
			BNDGGNDMEMC.MergeFrom(other.BNDGGNDMEMC);
		}
		if (other.StopDesc.Length != 0)
		{
			StopDesc = other.StopDesc;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				AvatarId = input.ReadUInt32();
				break;
			case 18u:
				if (hLHCKPPNPNH_ == null)
				{
					HLHCKPPNPNH = new HABFLMJEEKL();
				}
				input.ReadMessage(HLHCKPPNPNH);
				break;
			case 26u:
				if (bNDGGNDMEMC_ == null)
				{
					BNDGGNDMEMC = new HABFLMJEEKL();
				}
				input.ReadMessage(BNDGGNDMEMC);
				break;
			case 34u:
				StopDesc = input.ReadString();
				break;
			}
		}
	}
}
