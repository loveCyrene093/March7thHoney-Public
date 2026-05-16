using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BCMMLADBEAM : IMessage<BCMMLADBEAM>, IMessage, IEquatable<BCMMLADBEAM>, IDeepCloneable<BCMMLADBEAM>, IBufferMessage
{
	private static readonly MessageParser<BCMMLADBEAM> _parser = new MessageParser<BCMMLADBEAM>(() => new BCMMLADBEAM());

	private UnknownFieldSet _unknownFields;

	public const int MPLINCADODKFieldNumber = 15;

	private static readonly FieldCodec<GGINKEBLOEL> _repeated_mPLINCADODK_codec = FieldCodec.ForMessage(122u, GGINKEBLOEL.Parser);

	private readonly RepeatedField<GGINKEBLOEL> mPLINCADODK_ = new RepeatedField<GGINKEBLOEL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BCMMLADBEAM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BCMMLADBEAMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GGINKEBLOEL> MPLINCADODK => mPLINCADODK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCMMLADBEAM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCMMLADBEAM(BCMMLADBEAM other)
		: this()
	{
		mPLINCADODK_ = other.mPLINCADODK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCMMLADBEAM Clone()
	{
		return new BCMMLADBEAM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BCMMLADBEAM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BCMMLADBEAM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mPLINCADODK_.Equals(other.mPLINCADODK_))
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
		num ^= mPLINCADODK_.GetHashCode();
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
		mPLINCADODK_.WriteTo(ref output, _repeated_mPLINCADODK_codec);
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
		num += mPLINCADODK_.CalculateSize(_repeated_mPLINCADODK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BCMMLADBEAM other)
	{
		if (other != null)
		{
			mPLINCADODK_.Add(other.mPLINCADODK_);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mPLINCADODK_.AddEntriesFrom(ref input, _repeated_mPLINCADODK_codec);
			}
		}
	}
}
