using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DFGHKGDKCLB : IMessage<DFGHKGDKCLB>, IMessage, IEquatable<DFGHKGDKCLB>, IDeepCloneable<DFGHKGDKCLB>, IBufferMessage
{
	private static readonly MessageParser<DFGHKGDKCLB> _parser = new MessageParser<DFGHKGDKCLB>(() => new DFGHKGDKCLB());

	private UnknownFieldSet _unknownFields;

	public const int BEGMPEOFDLCFieldNumber = 6;

	private static readonly FieldCodec<LOBJLKHOLPG> _repeated_bEGMPEOFDLC_codec = FieldCodec.ForMessage(50u, LOBJLKHOLPG.Parser);

	private readonly RepeatedField<LOBJLKHOLPG> bEGMPEOFDLC_ = new RepeatedField<LOBJLKHOLPG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DFGHKGDKCLB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DFGHKGDKCLBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LOBJLKHOLPG> BEGMPEOFDLC => bEGMPEOFDLC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFGHKGDKCLB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFGHKGDKCLB(DFGHKGDKCLB other)
		: this()
	{
		bEGMPEOFDLC_ = other.bEGMPEOFDLC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFGHKGDKCLB Clone()
	{
		return new DFGHKGDKCLB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DFGHKGDKCLB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DFGHKGDKCLB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bEGMPEOFDLC_.Equals(other.bEGMPEOFDLC_))
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
		num ^= bEGMPEOFDLC_.GetHashCode();
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
		bEGMPEOFDLC_.WriteTo(ref output, _repeated_bEGMPEOFDLC_codec);
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
		num += bEGMPEOFDLC_.CalculateSize(_repeated_bEGMPEOFDLC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DFGHKGDKCLB other)
	{
		if (other != null)
		{
			bEGMPEOFDLC_.Add(other.bEGMPEOFDLC_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bEGMPEOFDLC_.AddEntriesFrom(ref input, _repeated_bEGMPEOFDLC_codec);
			}
		}
	}
}
