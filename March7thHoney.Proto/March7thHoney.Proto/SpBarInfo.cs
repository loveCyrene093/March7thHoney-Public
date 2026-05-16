using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpBarInfo : IMessage<SpBarInfo>, IMessage, IEquatable<SpBarInfo>, IDeepCloneable<SpBarInfo>, IBufferMessage
{
	private static readonly MessageParser<SpBarInfo> _parser = new MessageParser<SpBarInfo>(() => new SpBarInfo());

	private UnknownFieldSet _unknownFields;

	public const int CurSpFieldNumber = 1;

	private uint curSp_;

	public const int MaxSpFieldNumber = 2;

	private uint maxSp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpBarInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpBarInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurSp
	{
		get
		{
			return curSp_;
		}
		set
		{
			curSp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxSp
	{
		get
		{
			return maxSp_;
		}
		set
		{
			maxSp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpBarInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpBarInfo(SpBarInfo other)
		: this()
	{
		curSp_ = other.curSp_;
		maxSp_ = other.maxSp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpBarInfo Clone()
	{
		return new SpBarInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpBarInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpBarInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurSp != other.CurSp)
		{
			return false;
		}
		if (MaxSp != other.MaxSp)
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
		if (CurSp != 0)
		{
			num ^= CurSp.GetHashCode();
		}
		if (MaxSp != 0)
		{
			num ^= MaxSp.GetHashCode();
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
		if (CurSp != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CurSp);
		}
		if (MaxSp != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MaxSp);
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
		if (CurSp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurSp);
		}
		if (MaxSp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxSp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpBarInfo other)
	{
		if (other != null)
		{
			if (other.CurSp != 0)
			{
				CurSp = other.CurSp;
			}
			if (other.MaxSp != 0)
			{
				MaxSp = other.MaxSp;
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
			case 8u:
				CurSp = input.ReadUInt32();
				break;
			case 16u:
				MaxSp = input.ReadUInt32();
				break;
			}
		}
	}
}
