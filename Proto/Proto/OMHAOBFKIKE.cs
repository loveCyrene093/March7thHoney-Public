using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMHAOBFKIKE : IMessage<OMHAOBFKIKE>, IMessage, IEquatable<OMHAOBFKIKE>, IDeepCloneable<OMHAOBFKIKE>, IBufferMessage
{
	private static readonly MessageParser<OMHAOBFKIKE> _parser = new MessageParser<OMHAOBFKIKE>(() => new OMHAOBFKIKE());

	private UnknownFieldSet _unknownFields;

	public const int HIMECMGJKOMFieldNumber = 2;

	private MDIKAOAEJHN hIMECMGJKOM_;

	public const int AAGBLPKDJJPFieldNumber = 5;

	private MGGLDHHPNBM aAGBLPKDJJP_;

	public const int AvatarIdFieldNumber = 12;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMHAOBFKIKE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMHAOBFKIKEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDIKAOAEJHN HIMECMGJKOM
	{
		get
		{
			return hIMECMGJKOM_;
		}
		set
		{
			hIMECMGJKOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGGLDHHPNBM AAGBLPKDJJP
	{
		get
		{
			return aAGBLPKDJJP_;
		}
		set
		{
			aAGBLPKDJJP_ = value;
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
	public OMHAOBFKIKE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMHAOBFKIKE(OMHAOBFKIKE other)
		: this()
	{
		hIMECMGJKOM_ = other.hIMECMGJKOM_;
		aAGBLPKDJJP_ = ((other.aAGBLPKDJJP_ != null) ? other.aAGBLPKDJJP_.Clone() : null);
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMHAOBFKIKE Clone()
	{
		return new OMHAOBFKIKE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMHAOBFKIKE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMHAOBFKIKE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HIMECMGJKOM != other.HIMECMGJKOM)
		{
			return false;
		}
		if (!object.Equals(AAGBLPKDJJP, other.AAGBLPKDJJP))
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
		if (HIMECMGJKOM != MDIKAOAEJHN.Ihpfcmlekcg)
		{
			num ^= HIMECMGJKOM.GetHashCode();
		}
		if (aAGBLPKDJJP_ != null)
		{
			num ^= AAGBLPKDJJP.GetHashCode();
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
		if (HIMECMGJKOM != MDIKAOAEJHN.Ihpfcmlekcg)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)HIMECMGJKOM);
		}
		if (aAGBLPKDJJP_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(AAGBLPKDJJP);
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
		if (HIMECMGJKOM != MDIKAOAEJHN.Ihpfcmlekcg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HIMECMGJKOM);
		}
		if (aAGBLPKDJJP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AAGBLPKDJJP);
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
	public void MergeFrom(OMHAOBFKIKE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HIMECMGJKOM != MDIKAOAEJHN.Ihpfcmlekcg)
		{
			HIMECMGJKOM = other.HIMECMGJKOM;
		}
		if (other.aAGBLPKDJJP_ != null)
		{
			if (aAGBLPKDJJP_ == null)
			{
				AAGBLPKDJJP = new MGGLDHHPNBM();
			}
			AAGBLPKDJJP.MergeFrom(other.AAGBLPKDJJP);
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
			case 16u:
				HIMECMGJKOM = (MDIKAOAEJHN)input.ReadEnum();
				break;
			case 42u:
				if (aAGBLPKDJJP_ == null)
				{
					AAGBLPKDJJP = new MGGLDHHPNBM();
				}
				input.ReadMessage(AAGBLPKDJJP);
				break;
			case 96u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
