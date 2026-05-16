using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuitLineupScRsp : IMessage<QuitLineupScRsp>, IMessage, IEquatable<QuitLineupScRsp>, IDeepCloneable<QuitLineupScRsp>, IBufferMessage
{
	private static readonly MessageParser<QuitLineupScRsp> _parser = new MessageParser<QuitLineupScRsp>(() => new QuitLineupScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BaseAvatarIdFieldNumber = 5;

	private uint baseAvatarId_;

	public const int IsVirtualFieldNumber = 7;

	private bool isVirtual_;

	public const int LGFIFJDGEKBFieldNumber = 11;

	private bool lGFIFJDGEKB_;

	public const int PlaneIdFieldNumber = 12;

	private uint planeId_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuitLineupScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuitLineupScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsVirtual
	{
		get
		{
			return isVirtual_;
		}
		set
		{
			isVirtual_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LGFIFJDGEKB
	{
		get
		{
			return lGFIFJDGEKB_;
		}
		set
		{
			lGFIFJDGEKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitLineupScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitLineupScRsp(QuitLineupScRsp other)
		: this()
	{
		baseAvatarId_ = other.baseAvatarId_;
		isVirtual_ = other.isVirtual_;
		lGFIFJDGEKB_ = other.lGFIFJDGEKB_;
		planeId_ = other.planeId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitLineupScRsp Clone()
	{
		return new QuitLineupScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuitLineupScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuitLineupScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BaseAvatarId != other.BaseAvatarId)
		{
			return false;
		}
		if (IsVirtual != other.IsVirtual)
		{
			return false;
		}
		if (LGFIFJDGEKB != other.LGFIFJDGEKB)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
		}
		if (IsVirtual)
		{
			num ^= IsVirtual.GetHashCode();
		}
		if (LGFIFJDGEKB)
		{
			num ^= LGFIFJDGEKB.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BaseAvatarId);
		}
		if (IsVirtual)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsVirtual);
		}
		if (LGFIFJDGEKB)
		{
			output.WriteRawTag(88);
			output.WriteBool(LGFIFJDGEKB);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PlaneId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
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
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		if (IsVirtual)
		{
			num += 2;
		}
		if (LGFIFJDGEKB)
		{
			num += 2;
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuitLineupScRsp other)
	{
		if (other != null)
		{
			if (other.BaseAvatarId != 0)
			{
				BaseAvatarId = other.BaseAvatarId;
			}
			if (other.IsVirtual)
			{
				IsVirtual = other.IsVirtual;
			}
			if (other.LGFIFJDGEKB)
			{
				LGFIFJDGEKB = other.LGFIFJDGEKB;
			}
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 40u:
				BaseAvatarId = input.ReadUInt32();
				break;
			case 56u:
				IsVirtual = input.ReadBool();
				break;
			case 88u:
				LGFIFJDGEKB = input.ReadBool();
				break;
			case 96u:
				PlaneId = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
