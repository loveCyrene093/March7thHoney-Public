using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JMCJBDELOKJ : IMessage<JMCJBDELOKJ>, IMessage, IEquatable<JMCJBDELOKJ>, IDeepCloneable<JMCJBDELOKJ>, IBufferMessage
{
	private static readonly MessageParser<JMCJBDELOKJ> _parser = new MessageParser<JMCJBDELOKJ>(() => new JMCJBDELOKJ());

	private UnknownFieldSet _unknownFields;

	public const int MOFJKLHLDMDFieldNumber = 4;

	private static readonly FieldCodec<NOJNMAIACGB> _repeated_mOFJKLHLDMD_codec = FieldCodec.ForMessage(34u, NOJNMAIACGB.Parser);

	private readonly RepeatedField<NOJNMAIACGB> mOFJKLHLDMD_ = new RepeatedField<NOJNMAIACGB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JMCJBDELOKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JMCJBDELOKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NOJNMAIACGB> MOFJKLHLDMD => mOFJKLHLDMD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMCJBDELOKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMCJBDELOKJ(JMCJBDELOKJ other)
		: this()
	{
		mOFJKLHLDMD_ = other.mOFJKLHLDMD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMCJBDELOKJ Clone()
	{
		return new JMCJBDELOKJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JMCJBDELOKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JMCJBDELOKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mOFJKLHLDMD_.Equals(other.mOFJKLHLDMD_))
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
		num ^= mOFJKLHLDMD_.GetHashCode();
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
		mOFJKLHLDMD_.WriteTo(ref output, _repeated_mOFJKLHLDMD_codec);
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
		num += mOFJKLHLDMD_.CalculateSize(_repeated_mOFJKLHLDMD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JMCJBDELOKJ other)
	{
		if (other != null)
		{
			mOFJKLHLDMD_.Add(other.mOFJKLHLDMD_);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mOFJKLHLDMD_.AddEntriesFrom(ref input, _repeated_mOFJKLHLDMD_codec);
			}
		}
	}
}
