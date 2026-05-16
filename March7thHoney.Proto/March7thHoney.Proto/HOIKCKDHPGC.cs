using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HOIKCKDHPGC : IMessage<HOIKCKDHPGC>, IMessage, IEquatable<HOIKCKDHPGC>, IDeepCloneable<HOIKCKDHPGC>, IBufferMessage
{
	private static readonly MessageParser<HOIKCKDHPGC> _parser = new MessageParser<HOIKCKDHPGC>(() => new HOIKCKDHPGC());

	private UnknownFieldSet _unknownFields;

	public const int NPBKLCHLJMGFieldNumber = 2;

	private uint nPBKLCHLJMG_;

	public const int ONPKFDKADLAFieldNumber = 7;

	private uint oNPKFDKADLA_;

	public const int AvatarIdFieldNumber = 13;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HOIKCKDHPGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HOIKCKDHPGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPBKLCHLJMG
	{
		get
		{
			return nPBKLCHLJMG_;
		}
		set
		{
			nPBKLCHLJMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ONPKFDKADLA
	{
		get
		{
			return oNPKFDKADLA_;
		}
		set
		{
			oNPKFDKADLA_ = value;
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
	public HOIKCKDHPGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOIKCKDHPGC(HOIKCKDHPGC other)
		: this()
	{
		nPBKLCHLJMG_ = other.nPBKLCHLJMG_;
		oNPKFDKADLA_ = other.oNPKFDKADLA_;
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOIKCKDHPGC Clone()
	{
		return new HOIKCKDHPGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HOIKCKDHPGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HOIKCKDHPGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NPBKLCHLJMG != other.NPBKLCHLJMG)
		{
			return false;
		}
		if (ONPKFDKADLA != other.ONPKFDKADLA)
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
		if (NPBKLCHLJMG != 0)
		{
			num ^= NPBKLCHLJMG.GetHashCode();
		}
		if (ONPKFDKADLA != 0)
		{
			num ^= ONPKFDKADLA.GetHashCode();
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
		if (NPBKLCHLJMG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NPBKLCHLJMG);
		}
		if (ONPKFDKADLA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ONPKFDKADLA);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(104);
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
		if (NPBKLCHLJMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPBKLCHLJMG);
		}
		if (ONPKFDKADLA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ONPKFDKADLA);
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
	public void MergeFrom(HOIKCKDHPGC other)
	{
		if (other != null)
		{
			if (other.NPBKLCHLJMG != 0)
			{
				NPBKLCHLJMG = other.NPBKLCHLJMG;
			}
			if (other.ONPKFDKADLA != 0)
			{
				ONPKFDKADLA = other.ONPKFDKADLA;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				NPBKLCHLJMG = input.ReadUInt32();
				break;
			case 56u:
				ONPKFDKADLA = input.ReadUInt32();
				break;
			case 104u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
