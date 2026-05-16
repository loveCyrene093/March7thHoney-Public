using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KJAGLIIDBGP : IMessage<KJAGLIIDBGP>, IMessage, IEquatable<KJAGLIIDBGP>, IDeepCloneable<KJAGLIIDBGP>, IBufferMessage
{
	private static readonly MessageParser<KJAGLIIDBGP> _parser = new MessageParser<KJAGLIIDBGP>(() => new KJAGLIIDBGP());

	private UnknownFieldSet _unknownFields;

	public const int TalentInfoFieldNumber = 8;

	private MCACDFHCPIE talentInfo_;

	public const int DJCAJHIMDOLFieldNumber = 11;

	private uint dJCAJHIMDOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KJAGLIIDBGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KJAGLIIDBGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCACDFHCPIE TalentInfo
	{
		get
		{
			return talentInfo_;
		}
		set
		{
			talentInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DJCAJHIMDOL
	{
		get
		{
			return dJCAJHIMDOL_;
		}
		set
		{
			dJCAJHIMDOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJAGLIIDBGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJAGLIIDBGP(KJAGLIIDBGP other)
		: this()
	{
		talentInfo_ = ((other.talentInfo_ != null) ? other.talentInfo_.Clone() : null);
		dJCAJHIMDOL_ = other.dJCAJHIMDOL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJAGLIIDBGP Clone()
	{
		return new KJAGLIIDBGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KJAGLIIDBGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KJAGLIIDBGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TalentInfo, other.TalentInfo))
		{
			return false;
		}
		if (DJCAJHIMDOL != other.DJCAJHIMDOL)
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
		if (talentInfo_ != null)
		{
			num ^= TalentInfo.GetHashCode();
		}
		if (DJCAJHIMDOL != 0)
		{
			num ^= DJCAJHIMDOL.GetHashCode();
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
		if (talentInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(TalentInfo);
		}
		if (DJCAJHIMDOL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(DJCAJHIMDOL);
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
		if (talentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentInfo);
		}
		if (DJCAJHIMDOL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DJCAJHIMDOL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KJAGLIIDBGP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.talentInfo_ != null)
		{
			if (talentInfo_ == null)
			{
				TalentInfo = new MCACDFHCPIE();
			}
			TalentInfo.MergeFrom(other.TalentInfo);
		}
		if (other.DJCAJHIMDOL != 0)
		{
			DJCAJHIMDOL = other.DJCAJHIMDOL;
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
			case 66u:
				if (talentInfo_ == null)
				{
					TalentInfo = new MCACDFHCPIE();
				}
				input.ReadMessage(TalentInfo);
				break;
			case 88u:
				DJCAJHIMDOL = input.ReadUInt32();
				break;
			}
		}
	}
}
