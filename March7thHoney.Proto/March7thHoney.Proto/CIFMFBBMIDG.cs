using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIFMFBBMIDG : IMessage<CIFMFBBMIDG>, IMessage, IEquatable<CIFMFBBMIDG>, IDeepCloneable<CIFMFBBMIDG>, IBufferMessage
{
	private static readonly MessageParser<CIFMFBBMIDG> _parser = new MessageParser<CIFMFBBMIDG>(() => new CIFMFBBMIDG());

	private UnknownFieldSet _unknownFields;

	public const int HPLIBOGMCNJFieldNumber = 12;

	private static readonly FieldCodec<HLPMDJEKDCN> _repeated_hPLIBOGMCNJ_codec = FieldCodec.ForMessage(98u, HLPMDJEKDCN.Parser);

	private readonly RepeatedField<HLPMDJEKDCN> hPLIBOGMCNJ_ = new RepeatedField<HLPMDJEKDCN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIFMFBBMIDG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIFMFBBMIDGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HLPMDJEKDCN> HPLIBOGMCNJ => hPLIBOGMCNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIFMFBBMIDG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIFMFBBMIDG(CIFMFBBMIDG other)
		: this()
	{
		hPLIBOGMCNJ_ = other.hPLIBOGMCNJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIFMFBBMIDG Clone()
	{
		return new CIFMFBBMIDG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIFMFBBMIDG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIFMFBBMIDG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hPLIBOGMCNJ_.Equals(other.hPLIBOGMCNJ_))
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
		num ^= hPLIBOGMCNJ_.GetHashCode();
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
		hPLIBOGMCNJ_.WriteTo(ref output, _repeated_hPLIBOGMCNJ_codec);
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
		num += hPLIBOGMCNJ_.CalculateSize(_repeated_hPLIBOGMCNJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIFMFBBMIDG other)
	{
		if (other != null)
		{
			hPLIBOGMCNJ_.Add(other.hPLIBOGMCNJ_);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hPLIBOGMCNJ_.AddEntriesFrom(ref input, _repeated_hPLIBOGMCNJ_codec);
			}
		}
	}
}
