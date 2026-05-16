using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ECJNAIOLKJD : IMessage<ECJNAIOLKJD>, IMessage, IEquatable<ECJNAIOLKJD>, IDeepCloneable<ECJNAIOLKJD>, IBufferMessage
{
	private static readonly MessageParser<ECJNAIOLKJD> _parser = new MessageParser<ECJNAIOLKJD>(() => new ECJNAIOLKJD());

	private UnknownFieldSet _unknownFields;

	public const int PBCLKCBLMMIFieldNumber = 2;

	private uint pBCLKCBLMMI_;

	public const int TalentInfoFieldNumber = 5;

	private MCACDFHCPIE talentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ECJNAIOLKJD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ECJNAIOLKJDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBCLKCBLMMI
	{
		get
		{
			return pBCLKCBLMMI_;
		}
		set
		{
			pBCLKCBLMMI_ = value;
		}
	}

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
	public ECJNAIOLKJD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECJNAIOLKJD(ECJNAIOLKJD other)
		: this()
	{
		pBCLKCBLMMI_ = other.pBCLKCBLMMI_;
		talentInfo_ = ((other.talentInfo_ != null) ? other.talentInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECJNAIOLKJD Clone()
	{
		return new ECJNAIOLKJD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ECJNAIOLKJD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ECJNAIOLKJD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PBCLKCBLMMI != other.PBCLKCBLMMI)
		{
			return false;
		}
		if (!object.Equals(TalentInfo, other.TalentInfo))
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
		if (PBCLKCBLMMI != 0)
		{
			num ^= PBCLKCBLMMI.GetHashCode();
		}
		if (talentInfo_ != null)
		{
			num ^= TalentInfo.GetHashCode();
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
		if (PBCLKCBLMMI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PBCLKCBLMMI);
		}
		if (talentInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(TalentInfo);
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
		if (PBCLKCBLMMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBCLKCBLMMI);
		}
		if (talentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ECJNAIOLKJD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PBCLKCBLMMI != 0)
		{
			PBCLKCBLMMI = other.PBCLKCBLMMI;
		}
		if (other.talentInfo_ != null)
		{
			if (talentInfo_ == null)
			{
				TalentInfo = new MCACDFHCPIE();
			}
			TalentInfo.MergeFrom(other.TalentInfo);
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
			case 16u:
				PBCLKCBLMMI = input.ReadUInt32();
				break;
			case 42u:
				if (talentInfo_ == null)
				{
					TalentInfo = new MCACDFHCPIE();
				}
				input.ReadMessage(TalentInfo);
				break;
			}
		}
	}
}
