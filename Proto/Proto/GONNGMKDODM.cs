using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GONNGMKDODM : IMessage<GONNGMKDODM>, IMessage, IEquatable<GONNGMKDODM>, IDeepCloneable<GONNGMKDODM>, IBufferMessage
{
	private static readonly MessageParser<GONNGMKDODM> _parser = new MessageParser<GONNGMKDODM>(() => new GONNGMKDODM());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 5;

	private ulong uniqueId_;

	public const int BuffIdFieldNumber = 12;

	private uint buffId_;

	public const int HHMGFMPICAKFieldNumber = 13;

	private uint hHMGFMPICAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GONNGMKDODM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GONNGMKDODMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HHMGFMPICAK
	{
		get
		{
			return hHMGFMPICAK_;
		}
		set
		{
			hHMGFMPICAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GONNGMKDODM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GONNGMKDODM(GONNGMKDODM other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		buffId_ = other.buffId_;
		hHMGFMPICAK_ = other.hHMGFMPICAK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GONNGMKDODM Clone()
	{
		return new GONNGMKDODM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GONNGMKDODM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GONNGMKDODM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (HHMGFMPICAK != other.HHMGFMPICAK)
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
		if (UniqueId != 0L)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (HHMGFMPICAK != 0)
		{
			num ^= HHMGFMPICAK.GetHashCode();
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
		if (UniqueId != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(UniqueId);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BuffId);
		}
		if (HHMGFMPICAK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HHMGFMPICAK);
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
		if (UniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UniqueId);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (HHMGFMPICAK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HHMGFMPICAK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GONNGMKDODM other)
	{
		if (other != null)
		{
			if (other.UniqueId != 0L)
			{
				UniqueId = other.UniqueId;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.HHMGFMPICAK != 0)
			{
				HHMGFMPICAK = other.HHMGFMPICAK;
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
				UniqueId = input.ReadUInt64();
				break;
			case 96u:
				BuffId = input.ReadUInt32();
				break;
			case 104u:
				HHMGFMPICAK = input.ReadUInt32();
				break;
			}
		}
	}
}
