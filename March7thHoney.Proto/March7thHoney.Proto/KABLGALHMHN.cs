using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KABLGALHMHN : IMessage<KABLGALHMHN>, IMessage, IEquatable<KABLGALHMHN>, IDeepCloneable<KABLGALHMHN>, IBufferMessage
{
	private static readonly MessageParser<KABLGALHMHN> _parser = new MessageParser<KABLGALHMHN>(() => new KABLGALHMHN());

	private UnknownFieldSet _unknownFields;

	public const int GGCDDGIILJDFieldNumber = 10;

	private static readonly FieldCodec<HAHBEOHEALE> _repeated_gGCDDGIILJD_codec = FieldCodec.ForMessage(82u, HAHBEOHEALE.Parser);

	private readonly RepeatedField<HAHBEOHEALE> gGCDDGIILJD_ = new RepeatedField<HAHBEOHEALE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KABLGALHMHN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KABLGALHMHNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HAHBEOHEALE> GGCDDGIILJD => gGCDDGIILJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KABLGALHMHN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KABLGALHMHN(KABLGALHMHN other)
		: this()
	{
		gGCDDGIILJD_ = other.gGCDDGIILJD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KABLGALHMHN Clone()
	{
		return new KABLGALHMHN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KABLGALHMHN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KABLGALHMHN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gGCDDGIILJD_.Equals(other.gGCDDGIILJD_))
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
		num ^= gGCDDGIILJD_.GetHashCode();
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
		gGCDDGIILJD_.WriteTo(ref output, _repeated_gGCDDGIILJD_codec);
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
		num += gGCDDGIILJD_.CalculateSize(_repeated_gGCDDGIILJD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KABLGALHMHN other)
	{
		if (other != null)
		{
			gGCDDGIILJD_.Add(other.gGCDDGIILJD_);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gGCDDGIILJD_.AddEntriesFrom(ref input, _repeated_gGCDDGIILJD_codec);
			}
		}
	}
}
