using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BEAHIECJPPB : IMessage<BEAHIECJPPB>, IMessage, IEquatable<BEAHIECJPPB>, IDeepCloneable<BEAHIECJPPB>, IBufferMessage
{
	private static readonly MessageParser<BEAHIECJPPB> _parser = new MessageParser<BEAHIECJPPB>(() => new BEAHIECJPPB());

	private UnknownFieldSet _unknownFields;

	public const int CLCPLPPNNEHFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_cLCPLPPNNEH_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> cLCPLPPNNEH_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BEAHIECJPPB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BEAHIECJPPBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CLCPLPPNNEH => cLCPLPPNNEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEAHIECJPPB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEAHIECJPPB(BEAHIECJPPB other)
		: this()
	{
		cLCPLPPNNEH_ = other.cLCPLPPNNEH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEAHIECJPPB Clone()
	{
		return new BEAHIECJPPB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BEAHIECJPPB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BEAHIECJPPB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cLCPLPPNNEH_.Equals(other.cLCPLPPNNEH_))
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
		num ^= cLCPLPPNNEH_.GetHashCode();
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
		cLCPLPPNNEH_.WriteTo(ref output, _repeated_cLCPLPPNNEH_codec);
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
		num += cLCPLPPNNEH_.CalculateSize(_repeated_cLCPLPPNNEH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BEAHIECJPPB other)
	{
		if (other != null)
		{
			cLCPLPPNNEH_.Add(other.cLCPLPPNNEH_);
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
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cLCPLPPNNEH_.AddEntriesFrom(ref input, _repeated_cLCPLPPNNEH_codec);
			}
		}
	}
}
