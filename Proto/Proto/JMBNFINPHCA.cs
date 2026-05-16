using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JMBNFINPHCA : IMessage<JMBNFINPHCA>, IMessage, IEquatable<JMBNFINPHCA>, IDeepCloneable<JMBNFINPHCA>, IBufferMessage
{
	private static readonly MessageParser<JMBNFINPHCA> _parser = new MessageParser<JMBNFINPHCA>(() => new JMBNFINPHCA());

	private UnknownFieldSet _unknownFields;

	public const int NPCECMJGILBFieldNumber = 4;

	private static readonly FieldCodec<JFNAAFNLHNP> _repeated_nPCECMJGILB_codec = FieldCodec.ForMessage(34u, JFNAAFNLHNP.Parser);

	private readonly RepeatedField<JFNAAFNLHNP> nPCECMJGILB_ = new RepeatedField<JFNAAFNLHNP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JMBNFINPHCA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JMBNFINPHCAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JFNAAFNLHNP> NPCECMJGILB => nPCECMJGILB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMBNFINPHCA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMBNFINPHCA(JMBNFINPHCA other)
		: this()
	{
		nPCECMJGILB_ = other.nPCECMJGILB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMBNFINPHCA Clone()
	{
		return new JMBNFINPHCA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JMBNFINPHCA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JMBNFINPHCA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nPCECMJGILB_.Equals(other.nPCECMJGILB_))
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
		num ^= nPCECMJGILB_.GetHashCode();
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
		nPCECMJGILB_.WriteTo(ref output, _repeated_nPCECMJGILB_codec);
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
		num += nPCECMJGILB_.CalculateSize(_repeated_nPCECMJGILB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JMBNFINPHCA other)
	{
		if (other != null)
		{
			nPCECMJGILB_.Add(other.nPCECMJGILB_);
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
				nPCECMJGILB_.AddEntriesFrom(ref input, _repeated_nPCECMJGILB_codec);
			}
		}
	}
}
