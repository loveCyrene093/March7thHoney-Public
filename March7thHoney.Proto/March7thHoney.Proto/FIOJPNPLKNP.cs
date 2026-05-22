using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FIOJPNPLKNP : IMessage<FIOJPNPLKNP>, IMessage, IEquatable<FIOJPNPLKNP>, IDeepCloneable<FIOJPNPLKNP>, IBufferMessage
{
	private static readonly MessageParser<FIOJPNPLKNP> _parser = new MessageParser<FIOJPNPLKNP>(() => new FIOJPNPLKNP());

	private UnknownFieldSet _unknownFields;

	public const int HPOKOHJDDHOFieldNumber = 12;

	private NKPJCABNLKL hPOKOHJDDHO_;

	public const int HFJNDOAIDOPFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_hFJNDOAIDOP_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> hFJNDOAIDOP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FIOJPNPLKNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FIOJPNPLKNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKPJCABNLKL HPOKOHJDDHO
	{
		get
		{
			return hPOKOHJDDHO_;
		}
		set
		{
			hPOKOHJDDHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HFJNDOAIDOP => hFJNDOAIDOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIOJPNPLKNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIOJPNPLKNP(FIOJPNPLKNP other)
		: this()
	{
		hPOKOHJDDHO_ = other.hPOKOHJDDHO_;
		hFJNDOAIDOP_ = other.hFJNDOAIDOP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIOJPNPLKNP Clone()
	{
		return new FIOJPNPLKNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FIOJPNPLKNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FIOJPNPLKNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HPOKOHJDDHO != other.HPOKOHJDDHO)
		{
			return false;
		}
		if (!hFJNDOAIDOP_.Equals(other.hFJNDOAIDOP_))
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
		if (HPOKOHJDDHO != NKPJCABNLKL.Pcpdhelpkem)
		{
			num ^= HPOKOHJDDHO.GetHashCode();
		}
		num ^= hFJNDOAIDOP_.GetHashCode();
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
		if (HPOKOHJDDHO != NKPJCABNLKL.Pcpdhelpkem)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)HPOKOHJDDHO);
		}
		hFJNDOAIDOP_.WriteTo(ref output, _repeated_hFJNDOAIDOP_codec);
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
		if (HPOKOHJDDHO != NKPJCABNLKL.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HPOKOHJDDHO);
		}
		num += hFJNDOAIDOP_.CalculateSize(_repeated_hFJNDOAIDOP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FIOJPNPLKNP other)
	{
		if (other != null)
		{
			if (other.HPOKOHJDDHO != NKPJCABNLKL.Pcpdhelpkem)
			{
				HPOKOHJDDHO = other.HPOKOHJDDHO;
			}
			hFJNDOAIDOP_.Add(other.hFJNDOAIDOP_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 96u:
				HPOKOHJDDHO = (NKPJCABNLKL)input.ReadEnum();
				break;
			case 104u:
			case 106u:
				hFJNDOAIDOP_.AddEntriesFrom(ref input, _repeated_hFJNDOAIDOP_codec);
				break;
			}
		}
	}
}
