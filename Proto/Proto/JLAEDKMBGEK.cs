using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JLAEDKMBGEK : IMessage<JLAEDKMBGEK>, IMessage, IEquatable<JLAEDKMBGEK>, IDeepCloneable<JLAEDKMBGEK>, IBufferMessage
{
	private static readonly MessageParser<JLAEDKMBGEK> _parser = new MessageParser<JLAEDKMBGEK>(() => new JLAEDKMBGEK());

	private UnknownFieldSet _unknownFields;

	public const int TidFieldNumber = 4;

	private uint tid_;

	public const int NumFieldNumber = 11;

	private uint num_;

	public const int ExpireTimeFieldNumber = 12;

	private ulong expireTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JLAEDKMBGEK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JLAEDKMBGEKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Tid
	{
		get
		{
			return tid_;
		}
		set
		{
			tid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong ExpireTime
	{
		get
		{
			return expireTime_;
		}
		set
		{
			expireTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLAEDKMBGEK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLAEDKMBGEK(JLAEDKMBGEK other)
		: this()
	{
		tid_ = other.tid_;
		num_ = other.num_;
		expireTime_ = other.expireTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLAEDKMBGEK Clone()
	{
		return new JLAEDKMBGEK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JLAEDKMBGEK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JLAEDKMBGEK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Tid != other.Tid)
		{
			return false;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (ExpireTime != other.ExpireTime)
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
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (ExpireTime != 0L)
		{
			num ^= ExpireTime.GetHashCode();
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
		if (Tid != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Tid);
		}
		if (Num != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Num);
		}
		if (ExpireTime != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(ExpireTime);
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
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (ExpireTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ExpireTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JLAEDKMBGEK other)
	{
		if (other != null)
		{
			if (other.Tid != 0)
			{
				Tid = other.Tid;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.ExpireTime != 0L)
			{
				ExpireTime = other.ExpireTime;
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
			case 32u:
				Tid = input.ReadUInt32();
				break;
			case 88u:
				Num = input.ReadUInt32();
				break;
			case 96u:
				ExpireTime = input.ReadUInt64();
				break;
			}
		}
	}
}
