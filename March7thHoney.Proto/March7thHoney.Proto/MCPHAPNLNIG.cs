using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MCPHAPNLNIG : IMessage<MCPHAPNLNIG>, IMessage, IEquatable<MCPHAPNLNIG>, IDeepCloneable<MCPHAPNLNIG>, IBufferMessage
{
	private static readonly MessageParser<MCPHAPNLNIG> _parser = new MessageParser<MCPHAPNLNIG>(() => new MCPHAPNLNIG());

	private UnknownFieldSet _unknownFields;

	public const int BENEIFAHIGJFieldNumber = 8;

	private static readonly MapField<uint, uint>.Codec _map_bENEIFAHIGJ_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 66u);

	private readonly MapField<uint, uint> bENEIFAHIGJ_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MCPHAPNLNIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MCPHAPNLNIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> BENEIFAHIGJ => bENEIFAHIGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPHAPNLNIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPHAPNLNIG(MCPHAPNLNIG other)
		: this()
	{
		bENEIFAHIGJ_ = other.bENEIFAHIGJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPHAPNLNIG Clone()
	{
		return new MCPHAPNLNIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MCPHAPNLNIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MCPHAPNLNIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!BENEIFAHIGJ.Equals(other.BENEIFAHIGJ))
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
		num ^= BENEIFAHIGJ.GetHashCode();
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
		bENEIFAHIGJ_.WriteTo(ref output, _map_bENEIFAHIGJ_codec);
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
		num += bENEIFAHIGJ_.CalculateSize(_map_bENEIFAHIGJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MCPHAPNLNIG other)
	{
		if (other != null)
		{
			bENEIFAHIGJ_.MergeFrom(other.bENEIFAHIGJ_);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bENEIFAHIGJ_.AddEntriesFrom(ref input, _map_bENEIFAHIGJ_codec);
			}
		}
	}
}
