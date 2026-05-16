using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADHNJADIJAC : IMessage<ADHNJADIJAC>, IMessage, IEquatable<ADHNJADIJAC>, IDeepCloneable<ADHNJADIJAC>, IBufferMessage
{
	private static readonly MessageParser<ADHNJADIJAC> _parser = new MessageParser<ADHNJADIJAC>(() => new ADHNJADIJAC());

	private UnknownFieldSet _unknownFields;

	public const int BasicInfoFieldNumber = 1;

	private NIIGAPILPGD basicInfo_;

	public const int NEBABKOGGAAFieldNumber = 2;

	private PKEIDNJOLEL nEBABKOGGAA_;

	public const int StageInfoFieldNumber = 3;

	private LobbyGameExtInfo stageInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADHNJADIJAC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADHNJADIJACReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NIIGAPILPGD BasicInfo
	{
		get
		{
			return basicInfo_;
		}
		set
		{
			basicInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKEIDNJOLEL NEBABKOGGAA
	{
		get
		{
			return nEBABKOGGAA_;
		}
		set
		{
			nEBABKOGGAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGameExtInfo StageInfo
	{
		get
		{
			return stageInfo_;
		}
		set
		{
			stageInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADHNJADIJAC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADHNJADIJAC(ADHNJADIJAC other)
		: this()
	{
		basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
		nEBABKOGGAA_ = ((other.nEBABKOGGAA_ != null) ? other.nEBABKOGGAA_.Clone() : null);
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADHNJADIJAC Clone()
	{
		return new ADHNJADIJAC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADHNJADIJAC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADHNJADIJAC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BasicInfo, other.BasicInfo))
		{
			return false;
		}
		if (!object.Equals(NEBABKOGGAA, other.NEBABKOGGAA))
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
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
		if (basicInfo_ != null)
		{
			num ^= BasicInfo.GetHashCode();
		}
		if (nEBABKOGGAA_ != null)
		{
			num ^= NEBABKOGGAA.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
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
		if (basicInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BasicInfo);
		}
		if (nEBABKOGGAA_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(NEBABKOGGAA);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(StageInfo);
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
		if (basicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicInfo);
		}
		if (nEBABKOGGAA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NEBABKOGGAA);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADHNJADIJAC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.basicInfo_ != null)
		{
			if (basicInfo_ == null)
			{
				BasicInfo = new NIIGAPILPGD();
			}
			BasicInfo.MergeFrom(other.BasicInfo);
		}
		if (other.nEBABKOGGAA_ != null)
		{
			if (nEBABKOGGAA_ == null)
			{
				NEBABKOGGAA = new PKEIDNJOLEL();
			}
			NEBABKOGGAA.MergeFrom(other.NEBABKOGGAA);
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new LobbyGameExtInfo();
			}
			StageInfo.MergeFrom(other.StageInfo);
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
			case 10u:
				if (basicInfo_ == null)
				{
					BasicInfo = new NIIGAPILPGD();
				}
				input.ReadMessage(BasicInfo);
				break;
			case 18u:
				if (nEBABKOGGAA_ == null)
				{
					NEBABKOGGAA = new PKEIDNJOLEL();
				}
				input.ReadMessage(NEBABKOGGAA);
				break;
			case 26u:
				if (stageInfo_ == null)
				{
					StageInfo = new LobbyGameExtInfo();
				}
				input.ReadMessage(StageInfo);
				break;
			}
		}
	}
}
