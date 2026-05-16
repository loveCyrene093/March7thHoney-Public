using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GKPPDJEFBPA : IMessage<GKPPDJEFBPA>, IMessage, IEquatable<GKPPDJEFBPA>, IDeepCloneable<GKPPDJEFBPA>, IBufferMessage
{
	private static readonly MessageParser<GKPPDJEFBPA> _parser = new MessageParser<GKPPDJEFBPA>(() => new GKPPDJEFBPA());

	private UnknownFieldSet _unknownFields;

	public const int JAFNCOMGABGFieldNumber = 1;

	private uint jAFNCOMGABG_;

	public const int KBEFKONPKGJFieldNumber = 7;

	private ItemCostData kBEFKONPKGJ_;

	public const int EIIAGABAFECFieldNumber = 8;

	private uint eIIAGABAFEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GKPPDJEFBPA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GKPPDJEFBPAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData KBEFKONPKGJ
	{
		get
		{
			return kBEFKONPKGJ_;
		}
		set
		{
			kBEFKONPKGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKPPDJEFBPA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKPPDJEFBPA(GKPPDJEFBPA other)
		: this()
	{
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		kBEFKONPKGJ_ = ((other.kBEFKONPKGJ_ != null) ? other.kBEFKONPKGJ_.Clone() : null);
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKPPDJEFBPA Clone()
	{
		return new GKPPDJEFBPA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GKPPDJEFBPA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GKPPDJEFBPA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
		{
			return false;
		}
		if (!object.Equals(KBEFKONPKGJ, other.KBEFKONPKGJ))
		{
			return false;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
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
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
		}
		if (kBEFKONPKGJ_ != null)
		{
			num ^= KBEFKONPKGJ.GetHashCode();
		}
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
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
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JAFNCOMGABG);
		}
		if (kBEFKONPKGJ_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(KBEFKONPKGJ);
		}
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EIIAGABAFEC);
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
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (kBEFKONPKGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KBEFKONPKGJ);
		}
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GKPPDJEFBPA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JAFNCOMGABG != 0)
		{
			JAFNCOMGABG = other.JAFNCOMGABG;
		}
		if (other.kBEFKONPKGJ_ != null)
		{
			if (kBEFKONPKGJ_ == null)
			{
				KBEFKONPKGJ = new ItemCostData();
			}
			KBEFKONPKGJ.MergeFrom(other.KBEFKONPKGJ);
		}
		if (other.EIIAGABAFEC != 0)
		{
			EIIAGABAFEC = other.EIIAGABAFEC;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 8u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			case 58u:
				if (kBEFKONPKGJ_ == null)
				{
					KBEFKONPKGJ = new ItemCostData();
				}
				input.ReadMessage(KBEFKONPKGJ);
				break;
			case 64u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			}
		}
	}
}
