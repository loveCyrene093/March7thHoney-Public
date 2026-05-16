using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MEPLFBAKEFC : IMessage<MEPLFBAKEFC>, IMessage, IEquatable<MEPLFBAKEFC>, IDeepCloneable<MEPLFBAKEFC>, IBufferMessage
{
	private static readonly MessageParser<MEPLFBAKEFC> _parser = new MessageParser<MEPLFBAKEFC>(() => new MEPLFBAKEFC());

	private UnknownFieldSet _unknownFields;

	public const int DGOMHDMJHEKFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dGOMHDMJHEK_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dGOMHDMJHEK_ = new RepeatedField<uint>();

	public const int OGNDAAFIBIGFieldNumber = 10;

	private bool oGNDAAFIBIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MEPLFBAKEFC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MEPLFBAKEFCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DGOMHDMJHEK => dGOMHDMJHEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OGNDAAFIBIG
	{
		get
		{
			return oGNDAAFIBIG_;
		}
		set
		{
			oGNDAAFIBIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEPLFBAKEFC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEPLFBAKEFC(MEPLFBAKEFC other)
		: this()
	{
		dGOMHDMJHEK_ = other.dGOMHDMJHEK_.Clone();
		oGNDAAFIBIG_ = other.oGNDAAFIBIG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEPLFBAKEFC Clone()
	{
		return new MEPLFBAKEFC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MEPLFBAKEFC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MEPLFBAKEFC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dGOMHDMJHEK_.Equals(other.dGOMHDMJHEK_))
		{
			return false;
		}
		if (OGNDAAFIBIG != other.OGNDAAFIBIG)
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
		num ^= dGOMHDMJHEK_.GetHashCode();
		if (OGNDAAFIBIG)
		{
			num ^= OGNDAAFIBIG.GetHashCode();
		}
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
		dGOMHDMJHEK_.WriteTo(ref output, _repeated_dGOMHDMJHEK_codec);
		if (OGNDAAFIBIG)
		{
			output.WriteRawTag(80);
			output.WriteBool(OGNDAAFIBIG);
		}
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
		num += dGOMHDMJHEK_.CalculateSize(_repeated_dGOMHDMJHEK_codec);
		if (OGNDAAFIBIG)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MEPLFBAKEFC other)
	{
		if (other != null)
		{
			dGOMHDMJHEK_.Add(other.dGOMHDMJHEK_);
			if (other.OGNDAAFIBIG)
			{
				OGNDAAFIBIG = other.OGNDAAFIBIG;
			}
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
			case 24u:
			case 26u:
				dGOMHDMJHEK_.AddEntriesFrom(ref input, _repeated_dGOMHDMJHEK_codec);
				break;
			case 80u:
				OGNDAAFIBIG = input.ReadBool();
				break;
			}
		}
	}
}
