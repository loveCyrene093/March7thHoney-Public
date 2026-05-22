using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ABHOIALEGFI : IMessage<ABHOIALEGFI>, IMessage, IEquatable<ABHOIALEGFI>, IDeepCloneable<ABHOIALEGFI>, IBufferMessage
{
	private static readonly MessageParser<ABHOIALEGFI> _parser = new MessageParser<ABHOIALEGFI>(() => new ABHOIALEGFI());

	private UnknownFieldSet _unknownFields;

	public const int INKCBMFOJDMFieldNumber = 2;

	private static readonly FieldCodec<GICMHIBPIGI> _repeated_iNKCBMFOJDM_codec = FieldCodec.ForMessage(18u, GICMHIBPIGI.Parser);

	private readonly RepeatedField<GICMHIBPIGI> iNKCBMFOJDM_ = new RepeatedField<GICMHIBPIGI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ABHOIALEGFI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ABHOIALEGFIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GICMHIBPIGI> INKCBMFOJDM => iNKCBMFOJDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABHOIALEGFI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABHOIALEGFI(ABHOIALEGFI other)
		: this()
	{
		iNKCBMFOJDM_ = other.iNKCBMFOJDM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABHOIALEGFI Clone()
	{
		return new ABHOIALEGFI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ABHOIALEGFI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ABHOIALEGFI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iNKCBMFOJDM_.Equals(other.iNKCBMFOJDM_))
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
		num ^= iNKCBMFOJDM_.GetHashCode();
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
		iNKCBMFOJDM_.WriteTo(ref output, _repeated_iNKCBMFOJDM_codec);
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
		num += iNKCBMFOJDM_.CalculateSize(_repeated_iNKCBMFOJDM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ABHOIALEGFI other)
	{
		if (other != null)
		{
			iNKCBMFOJDM_.Add(other.iNKCBMFOJDM_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iNKCBMFOJDM_.AddEntriesFrom(ref input, _repeated_iNKCBMFOJDM_codec);
			}
		}
	}
}
