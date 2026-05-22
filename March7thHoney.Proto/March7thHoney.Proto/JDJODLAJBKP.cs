using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JDJODLAJBKP : IMessage<JDJODLAJBKP>, IMessage, IEquatable<JDJODLAJBKP>, IDeepCloneable<JDJODLAJBKP>, IBufferMessage
{
	private static readonly MessageParser<JDJODLAJBKP> _parser = new MessageParser<JDJODLAJBKP>(() => new JDJODLAJBKP());

	private UnknownFieldSet _unknownFields;

	public const int GLMFGMCPGHLFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_gLMFGMCPGHL_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> gLMFGMCPGHL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JDJODLAJBKP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JDJODLAJBKPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GLMFGMCPGHL => gLMFGMCPGHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDJODLAJBKP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDJODLAJBKP(JDJODLAJBKP other)
		: this()
	{
		gLMFGMCPGHL_ = other.gLMFGMCPGHL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDJODLAJBKP Clone()
	{
		return new JDJODLAJBKP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JDJODLAJBKP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JDJODLAJBKP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gLMFGMCPGHL_.Equals(other.gLMFGMCPGHL_))
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
		num ^= gLMFGMCPGHL_.GetHashCode();
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
		gLMFGMCPGHL_.WriteTo(ref output, _repeated_gLMFGMCPGHL_codec);
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
		num += gLMFGMCPGHL_.CalculateSize(_repeated_gLMFGMCPGHL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JDJODLAJBKP other)
	{
		if (other != null)
		{
			gLMFGMCPGHL_.Add(other.gLMFGMCPGHL_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gLMFGMCPGHL_.AddEntriesFrom(ref input, _repeated_gLMFGMCPGHL_codec);
			}
		}
	}
}
