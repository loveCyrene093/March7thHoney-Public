using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCIJHCFBGKG : IMessage<JCIJHCFBGKG>, IMessage, IEquatable<JCIJHCFBGKG>, IDeepCloneable<JCIJHCFBGKG>, IBufferMessage
{
	private static readonly MessageParser<JCIJHCFBGKG> _parser = new MessageParser<JCIJHCFBGKG>(() => new JCIJHCFBGKG());

	private UnknownFieldSet _unknownFields;

	public const int CJBBMAJIACIFieldNumber = 2;

	private uint cJBBMAJIACI_;

	public const int AFFAPLLEBBOFieldNumber = 3;

	private uint aFFAPLLEBBO_;

	public const int MEGCAGNHMIEFieldNumber = 8;

	private uint mEGCAGNHMIE_;

	public const int ENHOIMLIBJNFieldNumber = 13;

	private uint eNHOIMLIBJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCIJHCFBGKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCIJHCFBGKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJBBMAJIACI
	{
		get
		{
			return cJBBMAJIACI_;
		}
		set
		{
			cJBBMAJIACI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFFAPLLEBBO
	{
		get
		{
			return aFFAPLLEBBO_;
		}
		set
		{
			aFFAPLLEBBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MEGCAGNHMIE
	{
		get
		{
			return mEGCAGNHMIE_;
		}
		set
		{
			mEGCAGNHMIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ENHOIMLIBJN
	{
		get
		{
			return eNHOIMLIBJN_;
		}
		set
		{
			eNHOIMLIBJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCIJHCFBGKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCIJHCFBGKG(JCIJHCFBGKG other)
		: this()
	{
		cJBBMAJIACI_ = other.cJBBMAJIACI_;
		aFFAPLLEBBO_ = other.aFFAPLLEBBO_;
		mEGCAGNHMIE_ = other.mEGCAGNHMIE_;
		eNHOIMLIBJN_ = other.eNHOIMLIBJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCIJHCFBGKG Clone()
	{
		return new JCIJHCFBGKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCIJHCFBGKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCIJHCFBGKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CJBBMAJIACI != other.CJBBMAJIACI)
		{
			return false;
		}
		if (AFFAPLLEBBO != other.AFFAPLLEBBO)
		{
			return false;
		}
		if (MEGCAGNHMIE != other.MEGCAGNHMIE)
		{
			return false;
		}
		if (ENHOIMLIBJN != other.ENHOIMLIBJN)
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
		if (CJBBMAJIACI != 0)
		{
			num ^= CJBBMAJIACI.GetHashCode();
		}
		if (AFFAPLLEBBO != 0)
		{
			num ^= AFFAPLLEBBO.GetHashCode();
		}
		if (MEGCAGNHMIE != 0)
		{
			num ^= MEGCAGNHMIE.GetHashCode();
		}
		if (ENHOIMLIBJN != 0)
		{
			num ^= ENHOIMLIBJN.GetHashCode();
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
		if (CJBBMAJIACI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CJBBMAJIACI);
		}
		if (AFFAPLLEBBO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AFFAPLLEBBO);
		}
		if (MEGCAGNHMIE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MEGCAGNHMIE);
		}
		if (ENHOIMLIBJN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ENHOIMLIBJN);
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
		if (CJBBMAJIACI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJBBMAJIACI);
		}
		if (AFFAPLLEBBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFFAPLLEBBO);
		}
		if (MEGCAGNHMIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEGCAGNHMIE);
		}
		if (ENHOIMLIBJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ENHOIMLIBJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCIJHCFBGKG other)
	{
		if (other != null)
		{
			if (other.CJBBMAJIACI != 0)
			{
				CJBBMAJIACI = other.CJBBMAJIACI;
			}
			if (other.AFFAPLLEBBO != 0)
			{
				AFFAPLLEBBO = other.AFFAPLLEBBO;
			}
			if (other.MEGCAGNHMIE != 0)
			{
				MEGCAGNHMIE = other.MEGCAGNHMIE;
			}
			if (other.ENHOIMLIBJN != 0)
			{
				ENHOIMLIBJN = other.ENHOIMLIBJN;
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
			case 16u:
				CJBBMAJIACI = input.ReadUInt32();
				break;
			case 24u:
				AFFAPLLEBBO = input.ReadUInt32();
				break;
			case 64u:
				MEGCAGNHMIE = input.ReadUInt32();
				break;
			case 104u:
				ENHOIMLIBJN = input.ReadUInt32();
				break;
			}
		}
	}
}
