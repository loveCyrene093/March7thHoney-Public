using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DiceCombatModifyAvatarDiceCsReq : IMessage<DiceCombatModifyAvatarDiceCsReq>, IMessage, IEquatable<DiceCombatModifyAvatarDiceCsReq>, IDeepCloneable<DiceCombatModifyAvatarDiceCsReq>, IBufferMessage
{
	private static readonly MessageParser<DiceCombatModifyAvatarDiceCsReq> _parser = new MessageParser<DiceCombatModifyAvatarDiceCsReq>(() => new DiceCombatModifyAvatarDiceCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KNOPNCFBPEGFieldNumber = 10;

	private uint kNOPNCFBPEG_;

	public const int AvatarIdFieldNumber = 14;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DiceCombatModifyAvatarDiceCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DiceCombatModifyAvatarDiceCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KNOPNCFBPEG
	{
		get
		{
			return kNOPNCFBPEG_;
		}
		set
		{
			kNOPNCFBPEG_ = value;
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
	public DiceCombatModifyAvatarDiceCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatModifyAvatarDiceCsReq(DiceCombatModifyAvatarDiceCsReq other)
		: this()
	{
		kNOPNCFBPEG_ = other.kNOPNCFBPEG_;
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatModifyAvatarDiceCsReq Clone()
	{
		return new DiceCombatModifyAvatarDiceCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DiceCombatModifyAvatarDiceCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DiceCombatModifyAvatarDiceCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KNOPNCFBPEG != other.KNOPNCFBPEG)
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
		if (KNOPNCFBPEG != 0)
		{
			num ^= KNOPNCFBPEG.GetHashCode();
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
		if (KNOPNCFBPEG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KNOPNCFBPEG);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(112);
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
		if (KNOPNCFBPEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KNOPNCFBPEG);
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
	public void MergeFrom(DiceCombatModifyAvatarDiceCsReq other)
	{
		if (other != null)
		{
			if (other.KNOPNCFBPEG != 0)
			{
				KNOPNCFBPEG = other.KNOPNCFBPEG;
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
			case 80u:
				KNOPNCFBPEG = input.ReadUInt32();
				break;
			case 112u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
