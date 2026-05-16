using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MHANIEBKGHH : IMessage<MHANIEBKGHH>, IMessage, IEquatable<MHANIEBKGHH>, IDeepCloneable<MHANIEBKGHH>, IBufferMessage
{
	private static readonly MessageParser<MHANIEBKGHH> _parser = new MessageParser<MHANIEBKGHH>(() => new MHANIEBKGHH());

	private UnknownFieldSet _unknownFields;

	public const int EKCPIKGLIJIFieldNumber = 1;

	private uint eKCPIKGLIJI_;

	public const int HLKAFPCLMEOFieldNumber = 2;

	private bool hLKAFPCLMEO_;

	public const int KBAKJDJPCOFFieldNumber = 3;

	private HHIPKINNCAP kBAKJDJPCOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MHANIEBKGHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MHANIEBKGHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EKCPIKGLIJI
	{
		get
		{
			return eKCPIKGLIJI_;
		}
		set
		{
			eKCPIKGLIJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HLKAFPCLMEO
	{
		get
		{
			return hLKAFPCLMEO_;
		}
		set
		{
			hLKAFPCLMEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIPKINNCAP KBAKJDJPCOF
	{
		get
		{
			return kBAKJDJPCOF_;
		}
		set
		{
			kBAKJDJPCOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHANIEBKGHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHANIEBKGHH(MHANIEBKGHH other)
		: this()
	{
		eKCPIKGLIJI_ = other.eKCPIKGLIJI_;
		hLKAFPCLMEO_ = other.hLKAFPCLMEO_;
		kBAKJDJPCOF_ = ((other.kBAKJDJPCOF_ != null) ? other.kBAKJDJPCOF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHANIEBKGHH Clone()
	{
		return new MHANIEBKGHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MHANIEBKGHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MHANIEBKGHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EKCPIKGLIJI != other.EKCPIKGLIJI)
		{
			return false;
		}
		if (HLKAFPCLMEO != other.HLKAFPCLMEO)
		{
			return false;
		}
		if (!object.Equals(KBAKJDJPCOF, other.KBAKJDJPCOF))
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
		if (EKCPIKGLIJI != 0)
		{
			num ^= EKCPIKGLIJI.GetHashCode();
		}
		if (HLKAFPCLMEO)
		{
			num ^= HLKAFPCLMEO.GetHashCode();
		}
		if (kBAKJDJPCOF_ != null)
		{
			num ^= KBAKJDJPCOF.GetHashCode();
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
		if (EKCPIKGLIJI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EKCPIKGLIJI);
		}
		if (HLKAFPCLMEO)
		{
			output.WriteRawTag(16);
			output.WriteBool(HLKAFPCLMEO);
		}
		if (kBAKJDJPCOF_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(KBAKJDJPCOF);
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
		if (EKCPIKGLIJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKCPIKGLIJI);
		}
		if (HLKAFPCLMEO)
		{
			num += 2;
		}
		if (kBAKJDJPCOF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KBAKJDJPCOF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MHANIEBKGHH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EKCPIKGLIJI != 0)
		{
			EKCPIKGLIJI = other.EKCPIKGLIJI;
		}
		if (other.HLKAFPCLMEO)
		{
			HLKAFPCLMEO = other.HLKAFPCLMEO;
		}
		if (other.kBAKJDJPCOF_ != null)
		{
			if (kBAKJDJPCOF_ == null)
			{
				KBAKJDJPCOF = new HHIPKINNCAP();
			}
			KBAKJDJPCOF.MergeFrom(other.KBAKJDJPCOF);
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
				EKCPIKGLIJI = input.ReadUInt32();
				break;
			case 16u:
				HLKAFPCLMEO = input.ReadBool();
				break;
			case 26u:
				if (kBAKJDJPCOF_ == null)
				{
					KBAKJDJPCOF = new HHIPKINNCAP();
				}
				input.ReadMessage(KBAKJDJPCOF);
				break;
			}
		}
	}
}
