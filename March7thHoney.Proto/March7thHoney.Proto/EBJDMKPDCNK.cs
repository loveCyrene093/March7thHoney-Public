using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EBJDMKPDCNK : IMessage<EBJDMKPDCNK>, IMessage, IEquatable<EBJDMKPDCNK>, IDeepCloneable<EBJDMKPDCNK>, IBufferMessage
{
	private static readonly MessageParser<EBJDMKPDCNK> _parser = new MessageParser<EBJDMKPDCNK>(() => new EBJDMKPDCNK());

	private UnknownFieldSet _unknownFields;

	public const int LineupListFieldNumber = 1;

	private static readonly FieldCodec<JAFMFGJLGGA> _repeated_lineupList_codec = FieldCodec.ForMessage(10u, JAFMFGJLGGA.Parser);

	private readonly RepeatedField<JAFMFGJLGGA> lineupList_ = new RepeatedField<JAFMFGJLGGA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EBJDMKPDCNK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EBJDMKPDCNKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JAFMFGJLGGA> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBJDMKPDCNK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBJDMKPDCNK(EBJDMKPDCNK other)
		: this()
	{
		lineupList_ = other.lineupList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBJDMKPDCNK Clone()
	{
		return new EBJDMKPDCNK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EBJDMKPDCNK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EBJDMKPDCNK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lineupList_.Equals(other.lineupList_))
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
		num ^= lineupList_.GetHashCode();
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
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
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
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EBJDMKPDCNK other)
	{
		if (other != null)
		{
			lineupList_.Add(other.lineupList_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
			}
		}
	}
}
