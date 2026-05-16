using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBFDKMNGBKD : IMessage<NBFDKMNGBKD>, IMessage, IEquatable<NBFDKMNGBKD>, IDeepCloneable<NBFDKMNGBKD>, IBufferMessage
{
	private static readonly MessageParser<NBFDKMNGBKD> _parser = new MessageParser<NBFDKMNGBKD>(() => new NBFDKMNGBKD());

	private UnknownFieldSet _unknownFields;

	public const int DACOKFCBMBIFieldNumber = 5;

	private uint dACOKFCBMBI_;

	public const int UniqueIdFieldNumber = 12;

	private uint uniqueId_;

	public const int LLEEFDGJBKAFieldNumber = 13;

	private uint lLEEFDGJBKA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBFDKMNGBKD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBFDKMNGBKDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DACOKFCBMBI
	{
		get
		{
			return dACOKFCBMBI_;
		}
		set
		{
			dACOKFCBMBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
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
	public uint LLEEFDGJBKA
	{
		get
		{
			return lLEEFDGJBKA_;
		}
		set
		{
			lLEEFDGJBKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBFDKMNGBKD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBFDKMNGBKD(NBFDKMNGBKD other)
		: this()
	{
		dACOKFCBMBI_ = other.dACOKFCBMBI_;
		uniqueId_ = other.uniqueId_;
		lLEEFDGJBKA_ = other.lLEEFDGJBKA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBFDKMNGBKD Clone()
	{
		return new NBFDKMNGBKD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBFDKMNGBKD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBFDKMNGBKD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DACOKFCBMBI != other.DACOKFCBMBI)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (LLEEFDGJBKA != other.LLEEFDGJBKA)
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
		if (DACOKFCBMBI != 0)
		{
			num ^= DACOKFCBMBI.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (LLEEFDGJBKA != 0)
		{
			num ^= LLEEFDGJBKA.GetHashCode();
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
		if (DACOKFCBMBI != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DACOKFCBMBI);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(UniqueId);
		}
		if (LLEEFDGJBKA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LLEEFDGJBKA);
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
		if (DACOKFCBMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DACOKFCBMBI);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (LLEEFDGJBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLEEFDGJBKA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBFDKMNGBKD other)
	{
		if (other != null)
		{
			if (other.DACOKFCBMBI != 0)
			{
				DACOKFCBMBI = other.DACOKFCBMBI;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.LLEEFDGJBKA != 0)
			{
				LLEEFDGJBKA = other.LLEEFDGJBKA;
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
				DACOKFCBMBI = input.ReadUInt32();
				break;
			case 96u:
				UniqueId = input.ReadUInt32();
				break;
			case 104u:
				LLEEFDGJBKA = input.ReadUInt32();
				break;
			}
		}
	}
}
