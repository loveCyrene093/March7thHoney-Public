using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KMCOCFNCDEK : IMessage<KMCOCFNCDEK>, IMessage, IEquatable<KMCOCFNCDEK>, IDeepCloneable<KMCOCFNCDEK>, IBufferMessage
{
	private static readonly MessageParser<KMCOCFNCDEK> _parser = new MessageParser<KMCOCFNCDEK>(() => new KMCOCFNCDEK());

	private UnknownFieldSet _unknownFields;

	public const int LLEEFDGJBKAFieldNumber = 2;

	private uint lLEEFDGJBKA_;

	public const int UniqueIdFieldNumber = 6;

	private uint uniqueId_;

	public const int HNKNHCEIAIFFieldNumber = 14;

	private uint hNKNHCEIAIF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KMCOCFNCDEK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KMCOCFNCDEKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint HNKNHCEIAIF
	{
		get
		{
			return hNKNHCEIAIF_;
		}
		set
		{
			hNKNHCEIAIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMCOCFNCDEK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMCOCFNCDEK(KMCOCFNCDEK other)
		: this()
	{
		lLEEFDGJBKA_ = other.lLEEFDGJBKA_;
		uniqueId_ = other.uniqueId_;
		hNKNHCEIAIF_ = other.hNKNHCEIAIF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMCOCFNCDEK Clone()
	{
		return new KMCOCFNCDEK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KMCOCFNCDEK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KMCOCFNCDEK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LLEEFDGJBKA != other.LLEEFDGJBKA)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (HNKNHCEIAIF != other.HNKNHCEIAIF)
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
		if (LLEEFDGJBKA != 0)
		{
			num ^= LLEEFDGJBKA.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (HNKNHCEIAIF != 0)
		{
			num ^= HNKNHCEIAIF.GetHashCode();
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
		if (LLEEFDGJBKA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LLEEFDGJBKA);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(UniqueId);
		}
		if (HNKNHCEIAIF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HNKNHCEIAIF);
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
		if (LLEEFDGJBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLEEFDGJBKA);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (HNKNHCEIAIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HNKNHCEIAIF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KMCOCFNCDEK other)
	{
		if (other != null)
		{
			if (other.LLEEFDGJBKA != 0)
			{
				LLEEFDGJBKA = other.LLEEFDGJBKA;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.HNKNHCEIAIF != 0)
			{
				HNKNHCEIAIF = other.HNKNHCEIAIF;
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
				LLEEFDGJBKA = input.ReadUInt32();
				break;
			case 48u:
				UniqueId = input.ReadUInt32();
				break;
			case 112u:
				HNKNHCEIAIF = input.ReadUInt32();
				break;
			}
		}
	}
}
