using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNLIKADPCBH : IMessage<CNLIKADPCBH>, IMessage, IEquatable<CNLIKADPCBH>, IDeepCloneable<CNLIKADPCBH>, IBufferMessage
{
	private static readonly MessageParser<CNLIKADPCBH> _parser = new MessageParser<CNLIKADPCBH>(() => new CNLIKADPCBH());

	private UnknownFieldSet _unknownFields;

	public const int OEFHGDEMOMLFieldNumber = 3;

	private uint oEFHGDEMOML_;

	public const int OHAIEGCLPLHFieldNumber = 6;

	private uint oHAIEGCLPLH_;

	public const int IHLDDDHPOIOFieldNumber = 11;

	private EFEGKDHEMFN iHLDDDHPOIO_;

	public const int AvatarIdFieldNumber = 12;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNLIKADPCBH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNLIKADPCBHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OEFHGDEMOML
	{
		get
		{
			return oEFHGDEMOML_;
		}
		set
		{
			oEFHGDEMOML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OHAIEGCLPLH
	{
		get
		{
			return oHAIEGCLPLH_;
		}
		set
		{
			oHAIEGCLPLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN IHLDDDHPOIO
	{
		get
		{
			return iHLDDDHPOIO_;
		}
		set
		{
			iHLDDDHPOIO_ = value;
		}
	}

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
	public CNLIKADPCBH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNLIKADPCBH(CNLIKADPCBH other)
		: this()
	{
		oEFHGDEMOML_ = other.oEFHGDEMOML_;
		oHAIEGCLPLH_ = other.oHAIEGCLPLH_;
		iHLDDDHPOIO_ = ((other.iHLDDDHPOIO_ != null) ? other.iHLDDDHPOIO_.Clone() : null);
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNLIKADPCBH Clone()
	{
		return new CNLIKADPCBH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNLIKADPCBH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNLIKADPCBH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OEFHGDEMOML != other.OEFHGDEMOML)
		{
			return false;
		}
		if (OHAIEGCLPLH != other.OHAIEGCLPLH)
		{
			return false;
		}
		if (!object.Equals(IHLDDDHPOIO, other.IHLDDDHPOIO))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		if (OEFHGDEMOML != 0)
		{
			num ^= OEFHGDEMOML.GetHashCode();
		}
		if (OHAIEGCLPLH != 0)
		{
			num ^= OHAIEGCLPLH.GetHashCode();
		}
		if (iHLDDDHPOIO_ != null)
		{
			num ^= IHLDDDHPOIO.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
		if (OEFHGDEMOML != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OEFHGDEMOML);
		}
		if (OHAIEGCLPLH != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(OHAIEGCLPLH);
		}
		if (iHLDDDHPOIO_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(IHLDDDHPOIO);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AvatarId);
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
		if (OEFHGDEMOML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OEFHGDEMOML);
		}
		if (OHAIEGCLPLH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OHAIEGCLPLH);
		}
		if (iHLDDDHPOIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IHLDDDHPOIO);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNLIKADPCBH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OEFHGDEMOML != 0)
		{
			OEFHGDEMOML = other.OEFHGDEMOML;
		}
		if (other.OHAIEGCLPLH != 0)
		{
			OHAIEGCLPLH = other.OHAIEGCLPLH;
		}
		if (other.iHLDDDHPOIO_ != null)
		{
			if (iHLDDDHPOIO_ == null)
			{
				IHLDDDHPOIO = new EFEGKDHEMFN();
			}
			IHLDDDHPOIO.MergeFrom(other.IHLDDDHPOIO);
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
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
			case 24u:
				OEFHGDEMOML = input.ReadUInt32();
				break;
			case 48u:
				OHAIEGCLPLH = input.ReadUInt32();
				break;
			case 90u:
				if (iHLDDDHPOIO_ == null)
				{
					IHLDDDHPOIO = new EFEGKDHEMFN();
				}
				input.ReadMessage(IHLDDDHPOIO);
				break;
			case 96u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
