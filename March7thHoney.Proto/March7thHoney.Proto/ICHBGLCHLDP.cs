using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ICHBGLCHLDP : IMessage<ICHBGLCHLDP>, IMessage, IEquatable<ICHBGLCHLDP>, IDeepCloneable<ICHBGLCHLDP>, IBufferMessage
{
	private static readonly MessageParser<ICHBGLCHLDP> _parser = new MessageParser<ICHBGLCHLDP>(() => new ICHBGLCHLDP());

	private UnknownFieldSet _unknownFields;

	public const int LNFHNIJJFMMFieldNumber = 7;

	private static readonly FieldCodec<KDCIMCENCGP> _repeated_lNFHNIJJFMM_codec = FieldCodec.ForMessage(58u, KDCIMCENCGP.Parser);

	private readonly RepeatedField<KDCIMCENCGP> lNFHNIJJFMM_ = new RepeatedField<KDCIMCENCGP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ICHBGLCHLDP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ICHBGLCHLDPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KDCIMCENCGP> LNFHNIJJFMM => lNFHNIJJFMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHBGLCHLDP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHBGLCHLDP(ICHBGLCHLDP other)
		: this()
	{
		lNFHNIJJFMM_ = other.lNFHNIJJFMM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHBGLCHLDP Clone()
	{
		return new ICHBGLCHLDP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ICHBGLCHLDP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ICHBGLCHLDP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lNFHNIJJFMM_.Equals(other.lNFHNIJJFMM_))
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
		num ^= lNFHNIJJFMM_.GetHashCode();
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
		lNFHNIJJFMM_.WriteTo(ref output, _repeated_lNFHNIJJFMM_codec);
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
		num += lNFHNIJJFMM_.CalculateSize(_repeated_lNFHNIJJFMM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ICHBGLCHLDP other)
	{
		if (other != null)
		{
			lNFHNIJJFMM_.Add(other.lNFHNIJJFMM_);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lNFHNIJJFMM_.AddEntriesFrom(ref input, _repeated_lNFHNIJJFMM_codec);
			}
		}
	}
}
