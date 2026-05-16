using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AEBCLFBDHPE : IMessage<AEBCLFBDHPE>, IMessage, IEquatable<AEBCLFBDHPE>, IDeepCloneable<AEBCLFBDHPE>, IBufferMessage
{
	private static readonly MessageParser<AEBCLFBDHPE> _parser = new MessageParser<AEBCLFBDHPE>(() => new AEBCLFBDHPE());

	private UnknownFieldSet _unknownFields;

	public const int HEILKBJCAGBFieldNumber = 2;

	private uint hEILKBJCAGB_;

	public const int ALDJKJGBOJGFieldNumber = 5;

	private uint aLDJKJGBOJG_;

	public const int NHICMEMJFNIFieldNumber = 6;

	private FeverTimeBattleRank nHICMEMJFNI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AEBCLFBDHPE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AEBCLFBDHPEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEILKBJCAGB
	{
		get
		{
			return hEILKBJCAGB_;
		}
		set
		{
			hEILKBJCAGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ALDJKJGBOJG
	{
		get
		{
			return aLDJKJGBOJG_;
		}
		set
		{
			aLDJKJGBOJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeverTimeBattleRank NHICMEMJFNI
	{
		get
		{
			return nHICMEMJFNI_;
		}
		set
		{
			nHICMEMJFNI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEBCLFBDHPE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEBCLFBDHPE(AEBCLFBDHPE other)
		: this()
	{
		hEILKBJCAGB_ = other.hEILKBJCAGB_;
		aLDJKJGBOJG_ = other.aLDJKJGBOJG_;
		nHICMEMJFNI_ = other.nHICMEMJFNI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEBCLFBDHPE Clone()
	{
		return new AEBCLFBDHPE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AEBCLFBDHPE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AEBCLFBDHPE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HEILKBJCAGB != other.HEILKBJCAGB)
		{
			return false;
		}
		if (ALDJKJGBOJG != other.ALDJKJGBOJG)
		{
			return false;
		}
		if (NHICMEMJFNI != other.NHICMEMJFNI)
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
		if (HEILKBJCAGB != 0)
		{
			num ^= HEILKBJCAGB.GetHashCode();
		}
		if (ALDJKJGBOJG != 0)
		{
			num ^= ALDJKJGBOJG.GetHashCode();
		}
		if (NHICMEMJFNI != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
		{
			num ^= NHICMEMJFNI.GetHashCode();
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
		if (HEILKBJCAGB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HEILKBJCAGB);
		}
		if (ALDJKJGBOJG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ALDJKJGBOJG);
		}
		if (NHICMEMJFNI != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)NHICMEMJFNI);
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
		if (HEILKBJCAGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEILKBJCAGB);
		}
		if (ALDJKJGBOJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ALDJKJGBOJG);
		}
		if (NHICMEMJFNI != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NHICMEMJFNI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AEBCLFBDHPE other)
	{
		if (other != null)
		{
			if (other.HEILKBJCAGB != 0)
			{
				HEILKBJCAGB = other.HEILKBJCAGB;
			}
			if (other.ALDJKJGBOJG != 0)
			{
				ALDJKJGBOJG = other.ALDJKJGBOJG;
			}
			if (other.NHICMEMJFNI != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
			{
				NHICMEMJFNI = other.NHICMEMJFNI;
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
				HEILKBJCAGB = input.ReadUInt32();
				break;
			case 40u:
				ALDJKJGBOJG = input.ReadUInt32();
				break;
			case 48u:
				NHICMEMJFNI = (FeverTimeBattleRank)input.ReadEnum();
				break;
			}
		}
	}
}
