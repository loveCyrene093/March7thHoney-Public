using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FOFBDBJBEJE : IMessage<FOFBDBJBEJE>, IMessage, IEquatable<FOFBDBJBEJE>, IDeepCloneable<FOFBDBJBEJE>, IBufferMessage
{
	private static readonly MessageParser<FOFBDBJBEJE> _parser = new MessageParser<FOFBDBJBEJE>(() => new FOFBDBJBEJE());

	private UnknownFieldSet _unknownFields;

	public const int DPLPBDKDCKNFieldNumber = 9;

	private bool dPLPBDKDCKN_;

	public const int JAKNEBNDFFBFieldNumber = 14;

	private uint jAKNEBNDFFB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FOFBDBJBEJE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FOFBDBJBEJEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DPLPBDKDCKN
	{
		get
		{
			return dPLPBDKDCKN_;
		}
		set
		{
			dPLPBDKDCKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAKNEBNDFFB
	{
		get
		{
			return jAKNEBNDFFB_;
		}
		set
		{
			jAKNEBNDFFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFBDBJBEJE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFBDBJBEJE(FOFBDBJBEJE other)
		: this()
	{
		dPLPBDKDCKN_ = other.dPLPBDKDCKN_;
		jAKNEBNDFFB_ = other.jAKNEBNDFFB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFBDBJBEJE Clone()
	{
		return new FOFBDBJBEJE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FOFBDBJBEJE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FOFBDBJBEJE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DPLPBDKDCKN != other.DPLPBDKDCKN)
		{
			return false;
		}
		if (JAKNEBNDFFB != other.JAKNEBNDFFB)
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
		if (DPLPBDKDCKN)
		{
			num ^= DPLPBDKDCKN.GetHashCode();
		}
		if (JAKNEBNDFFB != 0)
		{
			num ^= JAKNEBNDFFB.GetHashCode();
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
		if (DPLPBDKDCKN)
		{
			output.WriteRawTag(72);
			output.WriteBool(DPLPBDKDCKN);
		}
		if (JAKNEBNDFFB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JAKNEBNDFFB);
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
		if (DPLPBDKDCKN)
		{
			num += 2;
		}
		if (JAKNEBNDFFB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAKNEBNDFFB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FOFBDBJBEJE other)
	{
		if (other != null)
		{
			if (other.DPLPBDKDCKN)
			{
				DPLPBDKDCKN = other.DPLPBDKDCKN;
			}
			if (other.JAKNEBNDFFB != 0)
			{
				JAKNEBNDFFB = other.JAKNEBNDFFB;
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
			case 72u:
				DPLPBDKDCKN = input.ReadBool();
				break;
			case 112u:
				JAKNEBNDFFB = input.ReadUInt32();
				break;
			}
		}
	}
}
