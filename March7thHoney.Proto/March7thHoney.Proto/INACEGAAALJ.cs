using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class INACEGAAALJ : IMessage<INACEGAAALJ>, IMessage, IEquatable<INACEGAAALJ>, IDeepCloneable<INACEGAAALJ>, IBufferMessage
{
	private static readonly MessageParser<INACEGAAALJ> _parser = new MessageParser<INACEGAAALJ>(() => new INACEGAAALJ());

	private UnknownFieldSet _unknownFields;

	public const int FLEOCMEFANHFieldNumber = 8;

	private uint fLEOCMEFANH_;

	public const int UnlockTimestampFieldNumber = 14;

	private long unlockTimestamp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<INACEGAAALJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => INACEGAAALJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FLEOCMEFANH
	{
		get
		{
			return fLEOCMEFANH_;
		}
		set
		{
			fLEOCMEFANH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UnlockTimestamp
	{
		get
		{
			return unlockTimestamp_;
		}
		set
		{
			unlockTimestamp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INACEGAAALJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INACEGAAALJ(INACEGAAALJ other)
		: this()
	{
		fLEOCMEFANH_ = other.fLEOCMEFANH_;
		unlockTimestamp_ = other.unlockTimestamp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INACEGAAALJ Clone()
	{
		return new INACEGAAALJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as INACEGAAALJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(INACEGAAALJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FLEOCMEFANH != other.FLEOCMEFANH)
		{
			return false;
		}
		if (UnlockTimestamp != other.UnlockTimestamp)
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
		if (FLEOCMEFANH != 0)
		{
			num ^= FLEOCMEFANH.GetHashCode();
		}
		if (UnlockTimestamp != 0L)
		{
			num ^= UnlockTimestamp.GetHashCode();
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
		if (FLEOCMEFANH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FLEOCMEFANH);
		}
		if (UnlockTimestamp != 0L)
		{
			output.WriteRawTag(112);
			output.WriteInt64(UnlockTimestamp);
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
		if (FLEOCMEFANH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLEOCMEFANH);
		}
		if (UnlockTimestamp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UnlockTimestamp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(INACEGAAALJ other)
	{
		if (other != null)
		{
			if (other.FLEOCMEFANH != 0)
			{
				FLEOCMEFANH = other.FLEOCMEFANH;
			}
			if (other.UnlockTimestamp != 0L)
			{
				UnlockTimestamp = other.UnlockTimestamp;
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
			case 64u:
				FLEOCMEFANH = input.ReadUInt32();
				break;
			case 112u:
				UnlockTimestamp = input.ReadInt64();
				break;
			}
		}
	}
}
